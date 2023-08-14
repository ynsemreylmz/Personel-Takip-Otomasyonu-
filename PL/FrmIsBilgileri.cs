using BLL;
using DAL;
using DAL.DTO;
using KaranlikTemaMesajKutusu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PL
{
	public partial class FrmIsBilgileri : Form
	{
		public FrmIsBilgileri()
		{
			InitializeComponent();
		}
		IsDTO dto = new IsDTO();
		bool combofull = false;

		public bool isUpdate = false;
		public IsDetayDTO detay = new IsDetayDTO();
		private void FrmIsBilgileri_Load(object sender, EventArgs e)
		{	
			cmbIsDurum.Visible = false;
			lblIsDurum.Visible=false;
			dto = IsBLL.GetAll();
			dataGridView1.DataSource = dto.Personeller;
			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[3].Visible = false;
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[7].Visible = false;
			dataGridView1.Columns[8].Visible = false;
			dataGridView1.Columns[9].Visible = false;
			dataGridView1.Columns[10].Visible = false;
			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[12].Visible = false;
			dataGridView1.Columns[13].Visible = false;
			cbmDepartman.DataSource = dto.Departmanlar;
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.DisplayMember = "PozisyonAd";
			cmbPozisyon.ValueMember = "ID";
			cmbPozisyon.SelectedIndex = -1;

			if (dto.Departmanlar.Count > 0) { combofull = true; }


			if (isUpdate)
			{
				cmbIsDurum.Visible = true;
				lblIsDurum.Visible = true;
				txtAdi.Text = detay.PersonelAd;
				txtSoyadi.Text = detay.PersonelSoyad;
				txtKullaniciNo.Text = detay.KullaniciNo.ToString();
				txtIcerik.Text = detay.Icerik;
				txtBaslik.Text = detay.Baslik;
				cmbIsDurum.DataSource = dto.Durumlar;
				cmbIsDurum.DisplayMember = "IsDurumAd";
				cmbIsDurum.ValueMember = "ID";
				cmbIsDurum.SelectedIndex = -1;
				cmbIsDurum.SelectedValue = detay.IsDurumID;


			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbmDepartman_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combofull)
			{
				int deparatmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
				cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == deparatmanID).ToList();
			}
		}


		I iss = new I();

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			iss = new I();
			iss.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			txtKullaniciNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}
		
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(iss.PersonelID == 0)
				MesajKutusu.MesajGoster("Personel Seçiniz.","Dikkat",MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if(txtBaslik.Text.Trim()=="")
				MesajKutusu.MesajGoster("Başlık Boş.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else if (txtIcerik.Text.Trim() == "")
				MesajKutusu.MesajGoster("İçerik Boş.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
			{	
				if(isUpdate)
				{
					DialogResult result = MesajKutusu.MesajGoster("DİKKAT", "Emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						IsDetayDTO dtoo = new IsDetayDTO();
						if(Convert.ToInt32(txtKullaniciNo.Text)!=detay.KullaniciNo)
						{
							dtoo.PersonelId = iss.PersonelID;

						}
						else
						{
							dtoo.PersonelId = detay.PersonelId; 
						}

						dtoo.Baslik = txtBaslik.Text;
						dtoo.Icerik = txtIcerik.Text;
						dtoo.IsDurumID = Convert.ToInt32(cmbIsDurum.SelectedValue);
						dtoo.IsID = detay.IsID;
						IsBLL.IsGüncelle(dtoo);

						MesajKutusu.MesajGoster("Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
				else
				{
					iss.Baslik = txtBaslik.Text;
					iss.Icerik = txtIcerik.Text;
					iss.IsDurumID = 1;
					iss.IsBaslamaTarihi = DateTime.Today;
					IsBLL.IsEkle(iss);
					MesajKutusu.MesajGoster("İş Eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtBaslik.Clear();
					txtIcerik.Clear();
				}


				
			}

		}
	}
}
