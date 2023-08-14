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

namespace PL
{
	public partial class FrmMaasBilgileri : Form
	{
		public FrmMaasBilgileri()
		{
			InitializeComponent();
		}
		MaasDTO dto = new MaasDTO();
		bool combofull = false;
		public bool isUpdate = false;
		public MaasDetayDTO detay = new MaasDetayDTO();
		private void FrmMaasBilgileri_Load(object sender, EventArgs e)
		{
			dto = MaasBLL.GetAll();
			
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
			cmbAy.DataSource = dto.Aylar;
			cmbAy.DisplayMember = "Ay";
			cmbAy.ValueMember = "ID";
			cmbAy.SelectedIndex = -1;
			txtYil.Text = DateTime.Today.Year.ToString();

			if (dto.Departmanlar.Count > 0)  combofull = true;


			if (isUpdate)
			{
				txtAdi.Text = detay.PersonelAd;
				txtSoyadi.Text = detay.PersonelSoyad;
				txtMaas.Text = detay.MaasMiktar.ToString();
				txtYil.Text = detay.MaasYıl.ToString();
				txtKullaniciNo.Text = detay.KullaniciNo.ToString();
				cmbAy.SelectedValue = detay.MaasAyID;
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
		MAA maas = new MAA();
		int maasmiktar = 0;
		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			maas.PersonelID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			txtKullaniciNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtSoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtMaas.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			maasmiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value)	;
		}
		
		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (maas.PersonelID ==0)
			{
				MesajKutusu.MesajGoster("Personel seç", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(txtMaas.Text.Trim().Length == 0)
			{
				MesajKutusu.MesajGoster("Maaş giriniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtYil.Text.Trim().Length == 0)
			{
				MesajKutusu.MesajGoster("Yıl giriniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (cmbAy.SelectedIndex ==-1)
			{
				MesajKutusu.MesajGoster("Ay seçiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				bool control = false;
				if (isUpdate)
				{
					DialogResult result = MesajKutusu.MesajGoster("Emin misiniz?","Dikkat",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result== DialogResult.Yes)
					{
						MaasDetayDTO maas = new MaasDetayDTO();
						maas.MaasID = detay.MaasID;
						maas.MaasAyID = Convert.ToInt32(cmbAy.SelectedValue);
						maas.MaasYıl = Convert.ToInt32(txtYil.Text);
						maas.EskiMaas = detay.MaasMiktar;
						maas.MaasMiktar = Convert.ToInt32(txtMaas.Text);
						maas.PersonelId = detay.PersonelId;

						if (maas.MaasMiktar > maas.EskiMaas)
						{
							control = true;
						}
						MaasBLL.MaasGüncelle(maas, control);
						MesajKutusu.MesajGoster("Maas güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
				else
				{
					if (Convert.ToInt32(txtMaas.Text) > maasmiktar)
					{
						control = true;
					}
					maas.AyID = Convert.ToInt32(cmbAy.SelectedValue);
					maas.Miktar = Convert.ToInt32(txtMaas.Text);
					maas.Yıl = Convert.ToInt32(txtYil.Text);
					MaasBLL.MaasEkle(maas,control);
					MesajKutusu.MesajGoster("Maaş Eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtMaas.Clear();
					maas = new MAA();
				}
				
				

			}
		}
	}
}
