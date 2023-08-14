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
	public partial class FrmMaasListele : Form
	{
		public FrmMaasListele()
		{
			InitializeComponent();
		}
		MaasDTO dto = new MaasDTO();
		bool combofull = false;
		MaasDetayDTO detay = new MaasDetayDTO();

		void Doldur()
		{
			dto = MaasBLL.GetAll();
			dataGridView1.DataSource = dto.Maaslar;
			dataGridView1.Columns[4].Visible = false;
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[7].Visible = false;
			dataGridView1.Columns[11].Visible = false;

			cbmDepartman.DataSource = dto.Departmanlar;
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.DisplayMember = "PozisyonAd";
			cmbPozisyon.ValueMember = "ID";
			cmbPozisyon.SelectedIndex = -1;
			if (dto.Departmanlar.Count > 0) { combofull = true; }
			cmbAy.DataSource = dto.Aylar;
			cmbAy.DisplayMember = "Ay";
			cmbAy.ValueMember = "ID";
			cmbAy.SelectedIndex = -1;
		}
		private void FrmMaasListele_Load(object sender, EventArgs e)
		{
			Doldur();

			if (!UserStatic.Admin)
			{
				btnEkle.Visible = false;
				btnGuncelle.Visible = false;
				btnSil.Visible = false;
				panel3.Visible = false;
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();	
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			var frm = new FrmMaasBilgileri();
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
			var frm = new FrmMaasBilgileri();
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
		List <MaasDetayDTO> listt = new List <MaasDetayDTO>();	
		private void btnAra_Click(object sender, EventArgs e)
		{
			listt = dto.Maaslar;
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
			if (cmbAy.SelectedIndex != -1)
				listt = listt.Where(x => x.MaasAyID == Convert.ToInt32(cmbAy.SelectedValue)).ToList();
			if (txtYil.Text.Trim().Length > 0)
				listt = listt.Where(x => x.KullaniciNo == Convert.ToInt32(txtYil.Text)).ToList();
			if(rbBüyük.Checked)
				listt=listt.Where(x=> x.MaasMiktar>Convert.ToInt32(txtMaas.Text)).ToList();
			else if (rbKucuk.Checked)
				listt = listt.Where(x => x.MaasMiktar < Convert.ToInt32(txtMaas.Text)).ToList();
			else if(rbEsit.Checked)
				listt = listt.Where(x => x.MaasMiktar == Convert.ToInt32(txtMaas.Text)).ToList();
			dataGridView1.DataSource = listt;

		}
		void Temizle()
		{
			dataGridView1.DataSource = dto.Maaslar;
			txtAdi.Clear();
			txtKullaniciNo.Clear();
			txtSoyadi.Clear();
			txtMaas.Clear();
			txtYil.Clear();
			cbmDepartman.SelectedIndex = -1;
			cmbAy.DataSource = dto.Aylar;
			cmbAy.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.SelectedIndex = -1;
			rbBüyük.Checked = false;
			rbEsit.Checked = false;
			rbKucuk.Checked = false;
		}
		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}

		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.MaasID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
			detay.PersonelId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
			detay.MaasAyID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);
			detay.MaasYıl = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
			detay.KullaniciNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
			detay.MaasMiktar = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
			detay.PersonelAd = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			detay.PersonelSoyad = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result = MesajKutusu.MesajGoster("Seçili ögeyi silemk istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{


				MaasBLL.Sil(detay.MaasID);
				MesajKutusu.MesajGoster("Silindi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				combofull = false;
				Temizle();
				Doldur();

			}
		}

		private void btnExel_Click(object sender, EventArgs e)
		{
			ExcelExport.ExportExcel(dataGridView1, "Maaş Listesi");
		}
	}
}
