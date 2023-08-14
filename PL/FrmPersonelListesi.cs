using BLL;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DTO;
using BLL;
using KaranlikTemaMesajKutusu;
using System.IO;

namespace PL
{
	public partial class FrmPersonelListesi : Form
	{	
		
		public FrmPersonelListesi()
		{
			InitializeComponent();
		}
		
        private void btnKapat_Click(object sender, EventArgs e)
		{	
			this.Close();
		}

		private void txtKullaniciNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		//Ekle
		private void button4_Click(object sender, EventArgs e)
		{
			var frm = new FrmPersonelBilgileri();
			this.Hide();//Form gizleme
			frm.isUpdate = false;
			
			frm.ShowDialog();
			
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			combofull = false;
			Temizle();
			Doldur();
			
		}
		//güncelle
		private void button3_Click(object sender, EventArgs e)
		{
			var frm = new FrmPersonelBilgileri();

			this.Hide();//Form gizleme
			frm.isUpdate = true;
			frm.detay = detay;
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			combofull = false;
			Temizle();
			Doldur();
		}
		
		PersonelDTO dto = new PersonelDTO();
		PersonelDetayDTO detay = new PersonelDetayDTO();




		bool combofull = false;
		List<PersonelDetayDTO> listt = new List<PersonelDetayDTO>();
		public void Listele()
		{
			listt = dto.Personeller;
			dgwPozisyonList.DataSource = listt;

		}
		void Doldur()
		{
			dto = PersonelBLL.GetAll();

			dgwPozisyonList.DataSource = dto.Personeller;


			cbmDepartman.DataSource = dto.Departmanlar;
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.DisplayMember = "PozisyonAd";
			cmbPozisyon.ValueMember = "ID";
			cmbPozisyon.SelectedIndex = -1;

			if (dto.Departmanlar.Count > 0) { combofull = true; }

			dgwPozisyonList.Columns[0].Visible = false;
			dgwPozisyonList.Columns[6].Visible = false;
			dgwPozisyonList.Columns[7].Visible = false;
			dgwPozisyonList.Columns[9].Visible = false;
			dgwPozisyonList.Columns[10].Visible = false;
			dgwPozisyonList.Columns[11].Visible = false;
		}

		void Temizle()
		{
			txtAdi.Clear();
			txtKullaniciNo.Clear();
			txtSoyadi.Clear();
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.SelectedIndex = -1;
			dgwPozisyonList.DataSource = dto.Personeller;
		}
		private void FrmPersonelListesi_Load(object sender, EventArgs e)
		{

			Doldur();

		}

		private void cbmDepartman_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combofull)
			{
				int deparatmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
				cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == deparatmanID).ToList();
			}
		}
	

		private void btnAra_Click(object sender, EventArgs e)
		{
			listt = dto.Personeller;
			if(txtKullaniciNo.Text.Trim().Length > 0)
				listt = listt.Where(x => x.KullaniciNo == Convert.ToInt32(txtKullaniciNo.Text)).ToList();
			if (txtAdi.Text.Trim().Length > 0) 
				listt = listt.Where(x=>x.PersonelAd.Contains(txtAdi.Text)).ToList();
			if (txtSoyadi.Text.Trim().Length > 0)
				listt = listt.Where(x => x.PersonelSoyad.Contains(txtSoyadi.Text)).ToList();
			if (cmbPozisyon.SelectedIndex != -1)
				listt = listt.Where(x => x.PozisyonID == Convert.ToInt32(cmbPozisyon.SelectedValue)).ToList();
			if (cbmDepartman.SelectedIndex != -1)
				listt = listt.Where(x => x.DepartmanID == Convert.ToInt32(cbmDepartman.SelectedValue)).ToList();

				dgwPozisyonList.DataSource = listt;
			
		}
		
		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dgwPozisyonList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{

			detay.PersonelId = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[0].Value);
			detay.PersonelAd = dgwPozisyonList.Rows[e.RowIndex].Cells[2].Value.ToString();
			detay.PersonelSoyad = dgwPozisyonList.Rows[e.RowIndex].Cells[3].Value.ToString();
			detay.KullaniciNo = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[1].Value);
			detay.DepartmanID = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[6].Value);
			detay.PozisyonID = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[7].Value);
			detay.Maas = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[8].Value);
			detay.Sifre = dgwPozisyonList.Rows[e.RowIndex].Cells[9].Value.ToString();
			detay.Admin = Convert.ToBoolean(dgwPozisyonList.Rows[e.RowIndex].Cells[10].Value);
			detay.Fotograf = dgwPozisyonList.Rows[e.RowIndex].Cells[11].Value.ToString();
			detay.Adres = dgwPozisyonList.Rows[e.RowIndex].Cells[12].Value.ToString();
			detay.DogumTarihi = Convert.ToDateTime(dgwPozisyonList.Rows[e.RowIndex].Cells[13].Value);

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result = MesajKutusu.MesajGoster("Seçili ögeyi silemk istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{


				PersonelBLL.Sil(detay.PersonelId);
				string resimyol = Application.StartupPath + "\\resimler\\" + detay.Fotograf;
				File.Delete(resimyol);
				MesajKutusu.MesajGoster("Silindi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				combofull = false;
				Temizle();
				Doldur();

			}
		}

		private void btnExel_Click(object sender, EventArgs e)
		{
			ExcelExport.ExportExcel(dgwPozisyonList, "Personel Listesi");
		}
	}
}
