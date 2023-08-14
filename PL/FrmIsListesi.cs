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
using System.Collections;
using KaranlikTemaMesajKutusu;

namespace PL
{
	public partial class FrmIsListesi : Form
	{
		public FrmIsListesi()
		{
			InitializeComponent();
		}

		private void txtKullaniciNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		IsDTO dto = new IsDTO();
		IsDetayDTO detay = new IsDetayDTO();
		bool combofull = false;
		private void FrmIsListesi_Load(object sender, EventArgs e)
		{
			
			Doldur();
		}
		void Doldur()
		{
			dto = IsBLL.GetAll();
			dataGridView1.DataSource = dto.Isler;

			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[12].Visible = false;
			dataGridView1.Columns[10].Visible = false;
			dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[13].Visible = false;
			dataGridView1.Columns[14].Visible = false;
			dataGridView1.Columns[7].Visible = false;


			cbmDepartman.DataSource = dto.Departmanlar;
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.DisplayMember = "PozisyonAd";
			cmbPozisyon.ValueMember = "ID";
			cmbPozisyon.SelectedIndex = -1;
			cbxIsDurum.DataSource = dto.Durumlar;
			cbxIsDurum.DisplayMember = "DurumAd";
			cbxIsDurum.ValueMember = "ID";
			cbxIsDurum.SelectedIndex = -1;
			if (dto.Departmanlar.Count > 0)
			{
				combofull = true;

			}
			if (!UserStatic.Admin)
			{
				btnEkle.Visible = false;
				btnSil.Visible = false;
				btnGuncelle.Visible = false;
				btnOnayla.Text = "Tamamla";
				pnlAdmin.Visible = false;
				dto.Isler = dto.Isler.Where(x=>x.PersonelId==UserStatic.PersonelId).ToList();
			}
		}
		private void btnEkle_Click(object sender, EventArgs e)
		{	
			
			var frm = new FrmIsBilgileri();
			this.Hide();//Form gizleme
			frm.isUpdate = false;
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			combofull = false;
			Doldur();
			Temizle();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			var frm = new FrmIsBilgileri();
			this.Hide();//Form gizleme
			frm.isUpdate = true;
			frm.detay = detay;
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			combofull = false;
			Doldur();
			Temizle();
		}

		private void cbmDepartman_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combofull)
			{
				int deparatmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
				cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == deparatmanID).ToList();
			}
		}
		List <IsDetayDTO> listt = new List <IsDetayDTO>();
		private void btnAra_Click(object sender, EventArgs e)
		{
			listt= dto.Isler;
			if (txtKullaniciNo.Text.Trim().Length > 0)
				listt = listt.Where(x => x.KullaniciNo == Convert.ToInt32(txtKullaniciNo.Text)).ToList();
			if (txtAdi.Text.Trim().Length > 0)
				listt = listt.Where(x => x.PersonelAd.Contains(txtAdi.Text)).ToList();
			if (txtSoyadi.Text.Trim().Length > 0)
				listt = listt.Where(x => x.PersonelSoyad.Contains(txtSoyadi.Text)).ToList();
			if (cmbPozisyon.SelectedIndex != -1)
				listt = listt.Where(x => x.PozisyonID == Convert.ToInt32(cmbPozisyon.SelectedValue)).ToList();
			if (cbmDepartman.SelectedIndex != -1)
				listt = listt.Where(x => x.DepartmanID == Convert.ToInt32(cbmDepartman.SelectedValue)).ToList();
			if (cbxIsDurum.SelectedIndex != -1)
				listt = listt.Where(x => x.IsDurumID == Convert.ToInt32(cbxIsDurum.SelectedValue)).ToList();
			if (rbtnBaslama.Checked)
			{
				listt = listt.Where(x=>x.IsBaslama>= Convert.ToDateTime(dpBaslama.Value) && x.IsBaslama <Convert.ToDateTime(dpBaslama.Value)).ToList();
			}
			if (rbtnBitis.Checked)
			{
				listt = listt.Where(x => x.IsBitis >= Convert.ToDateTime(dpBaslama.Value) && x.IsBitis < Convert.ToDateTime(dpBaslama.Value)).ToList();
			}
			dataGridView1.DataSource = listt;
		}
		void Temizle()
		{
			txtAdi.Clear();
			txtSoyadi.Clear();
			txtKullaniciNo.Clear();
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.SelectedIndex = -1;
			cbxIsDurum.SelectedIndex = -1;
			dpBaslama.Value = DateTime.Today;
			dpBitis.Value = DateTime.Today;
			
			dataGridView1.DataSource = dto.Isler;

		}
		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();

		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.IsID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
			detay.KullaniciNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
			detay.PersonelId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
			detay.IsDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
			detay.Baslik = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			detay.Icerik = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
			detay.PersonelAd = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			detay.PersonelSoyad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			detay.IsBitis = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
			detay.IsBaslama = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result = MesajKutusu.MesajGoster("Seçili ögeyi silemk istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				
				
					IsBLL.Sil(detay.IsID);
					MesajKutusu.MesajGoster("Silindi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					combofull = false;
					Temizle();
					Doldur();
				
			}
		}

		private void btnOnayla_Click(object sender, EventArgs e)
		{
			if(UserStatic.Admin && detay.IsDurumID == OnayStatic.Onaylandı)
				MesajKutusu.MesajGoster("Bu iş henüz onaylanmış","",MessageBoxButtons.OK,MessageBoxIcon.Information);
			else if (UserStatic.Admin && detay.IsDurumID == OnayStatic.Personelde && detay.PersonelId!=UserStatic.PersonelId)
				MesajKutusu.MesajGoster("Bu iş henüz tamamlanmamış", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else if (!UserStatic.Admin && detay.IsDurumID == OnayStatic.Tamamlandı)
				MesajKutusu.MesajGoster("Bu iş zaten tamamlanmış", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
			{
				IsBLL.IsGüncelle(detay.IsID);
				MesajKutusu.MesajGoster("Onaylandı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				combofull = false;
				Temizle();
				Doldur();
			}
		}

		private void btnExel_Click(object sender, EventArgs e)
		{
			ExcelExport.ExportExcel(dataGridView1,"İş Listesi");
		}
	}
}
