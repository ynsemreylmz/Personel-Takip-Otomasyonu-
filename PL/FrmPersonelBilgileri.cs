using BLL;
using DAL;
using DAL.DTO;
using KaranlikTemaMesajKutusu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
	public partial class FrmPersonelBilgileri : Form
	{
		public FrmPersonelBilgileri()
		{
			InitializeComponent();
		}
		
		private void btnKapat_Click(object sender, EventArgs e)
		{
		

			this.Close();
		}

		private void txtMaas_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void txtKullaniciNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		PersonelDTO dto = new PersonelDTO();
		public PersonelDetayDTO detay = new PersonelDetayDTO();
		public bool isUpdate = false;
		string resim = "";



		private void FrmPersonelBilgileri_Load(object sender, EventArgs e)
		{
			
			 
			dto = PersonelBLL.GetAll();
			cbmDepartman.DataSource = dto.Departmanlar;
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.DisplayMember = "PozisyonAd";
			cmbPozisyon.ValueMember = "ID";
			cmbPozisyon.SelectedIndex = -1;
			
			if (dto.Departmanlar.Count > 0)
			{
				combofull = true;
			}
			
			if (isUpdate)
			{
				txtAdi.Text = detay.PersonelAd;
				txtSoyadi.Text = detay.PersonelSoyad;
				txtAdres.Text = detay.Adres;
				txtMaas.Text = detay.Maas.ToString();
				txtSifre.Text = detay.Sifre;
				txtKullaniciNo.Text = detay.KullaniciNo.ToString();
				chxAdmin.Checked = detay.Admin;
				cbmDepartman.SelectedValue = detay.DepartmanID;
				cmbPozisyon.SelectedValue = detay.PozisyonID;
				resim = Application.StartupPath + "\\resimler\\" + detay.Fotograf;
				txtBoxFoto.Text = resim;
				//Hata
				pictureBox1.Load(resim);
				//Hata
				if (!UserStatic.Admin)
				{
					txtAdi.Enabled = false;
					txtSoyadi.Enabled = false;
					txtMaas.Enabled = false;
					txtKullaniciNo.Enabled = false;
					chxAdmin.Enabled = false;
					cmbPozisyon.Enabled = false;
					cbmDepartman.Enabled = false;
					dateTimePicker1.Enabled = false;
				}
			}
		}

		bool combofull = false;
		string resimad = "";

		private void cbmDepartman_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combofull) 
				{
				int deparatmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
				cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == deparatmanID).ToList();
			} 

			
		}
		bool dosya = false;
		private void button1_Click(object sender, EventArgs e)
		{
			if(openFileDialog1.ShowDialog()==DialogResult.OK)
			{
				dosya = true;
				pictureBox1.Load(openFileDialog1.FileName);
				txtBoxFoto.Text = openFileDialog1.FileName;
				resimad = Guid.NewGuid().ToString();
				resimad += openFileDialog1.SafeFileName;
			}
		}
		
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			
			
			List<string> list = new List<string>();
			
			bool test = true;
			if (txtKullaniciNo.Text.Trim() == "")
			{	
				list.Add(txtKullaniciNo.AccessibleName.ToString());
				test=false;
			}
			
			else if (txtAdi.Text.Trim() == "")
			{
				list.Add(txtAdi.AccessibleName.ToString());
				test = false;
			}
			else if (txtSoyadi.Text.Trim() == "")
			{
				list.Add(txtSoyadi.AccessibleName.ToString());
				test = false;
			}
			else if (txtBoxFoto.Text.Trim() == "")
			{
				list.Add(txtBoxFoto.AccessibleName.ToString());
				test = false;
			}
			else if (txtMaas.Text.Trim() == "")
			{
				list.Add(txtMaas.AccessibleName.ToString());
				test = false;
			}
			else if (txtSifre.Text.Trim() == "")
			{
				list.Add(txtSifre.AccessibleName.ToString());
				test = false;
			}
			else if(cmbPozisyon.SelectedIndex == -1)
			{
				list.Add(cmbPozisyon.AccessibleName.ToString());
				test = false;
			}
			else if (cbmDepartman.SelectedIndex == -1)
			{
				list.Add(cbmDepartman.AccessibleName.ToString());
				test = false;
			}

			if (test)
			{
				if (isUpdate)
				{

					DialogResult result = MesajKutusu.MesajGoster("Emin misin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result == DialogResult.Yes)
					{
						PersonelDetayDTO pr = new PersonelDetayDTO();
						pr.PersonelId = detay.PersonelId;
						pr.KullaniciNo = Convert.ToInt32(txtKullaniciNo.Text);
						pr.PersonelAd = txtAdi.Text.Trim();
						pr.PersonelSoyad = txtSoyadi.Text.Trim();
						pr.Maas = Convert.ToInt32(txtMaas.Text);
						pr.Admin = chxAdmin.Checked;
						pr.Sifre = txtSifre.Text.Trim();
						pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
						pr.DepartmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
						pr.DogumTarihi = dateTimePicker1.Value;
						pr.Adres = txtAdres.Text.Trim();
						

						if (resim !=txtBoxFoto.Text)
						{
							pr.Fotograf = resimad;

							if (File.Exists(resim))
							{
								File.Delete(resim);
							}

							File.Copy(txtBoxFoto.Text, @"resimler\\" + resimad);
						}
						else
						{
							pr.Fotograf = detay.Fotograf;
							

						}
						PersonelBLL.PersonelGüncelle(pr);
						MesajKutusu.MesajGoster("Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();

					}

				}
				else
				{
					if (PersonelBLL.IsUnique(Convert.ToInt32(txtKullaniciNo.Text)))
					{
						MesajKutusu.MesajGoster("Kullanıcı No Kullanılmakta.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					else
					{
						PERSONEL pr = new PERSONEL();
						pr.UserNo = Convert.ToInt32(txtKullaniciNo.Text);
						pr.Ad = txtAdi.Text.Trim();
						pr.Soyad = txtSoyadi.Text.Trim();
						pr.Maas = Convert.ToInt32(txtMaas.Text);
						pr.Admin = chxAdmin.Checked;
						pr.Sifre = txtSifre.Text.Trim();
						pr.PozisyonID = Convert.ToInt32(cmbPozisyon.SelectedValue);
						pr.DepartmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
						pr.DogumGunu = dateTimePicker1.Value;
						pr.Adres = txtAdres.Text.Trim();
						pr.Resim = resimad;
						PersonelBLL.PersonelEkle(pr);
						File.Copy(txtBoxFoto.Text, @"resimler\\" + resimad);
						MesajKutusu.MesajGoster("Personel Başarılı bir şekilde eklendi", "personel Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						txtKullaniciNo.Clear();
						txtAdi.Clear();
						txtSoyadi.Clear();
						txtMaas.Clear();
						chxAdmin.Checked = false;
						txtSifre.Clear();
						cbmDepartman.SelectedIndex = -1;
						cmbPozisyon.DataSource = dto.Pozisyonlar;
						cmbPozisyon.SelectedIndex = -1;
						dateTimePicker1.Value = DateTime.Today;
						txtAdres.Clear();
						txtBoxFoto.Clear();
						resimad = "";
					}

				
			}
			}
			else
			{
				string result = String.Join(", ", list);
				MesajKutusu.MesajGoster(result + " Bilgileri boş olamaz.", "BOŞ DEĞER", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}


			
			



		}

		private void btnKontrol_Click(object sender, EventArgs e)
		{	
			if(txtKullaniciNo.Text.Trim() == "")
			{
				MesajKutusu.MesajGoster("Kullanıcı No Boş", "Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else if (PersonelBLL.IsUnique(Convert.ToInt32(txtKullaniciNo.Text)))
			{
				MesajKutusu.MesajGoster("Kullanıcı No Kullanılmakta.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				MesajKutusu.MesajGoster("Bu Kullanıcı No kullanılabilir.", "",  MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
