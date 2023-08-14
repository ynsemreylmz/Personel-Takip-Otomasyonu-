using BLL;
using DAL;
using DAL.DTO;
using KaranlikTemaMesajKutusu;
using System;
using System.Collections;
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
	public partial class FrmIzinListele : Form
	{
		public FrmIzinListele()
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

		private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
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
		IzınDTO dto = new IzınDTO();
		bool combofull = false;
		void Doldur()
		{
			dto = IzınBLL.GetAll();
			dataGridView1.DataSource = dto.Izinler;

			dataGridView1.Columns[0].Visible = false;
			dataGridView1.Columns[6].Visible = false;
			dataGridView1.Columns[7].Visible = false;
			dataGridView1.Columns[4].Visible = false;
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[14].Visible = false;
			dataGridView1.Columns[11].Visible = false;
			dataGridView1.Columns[14].Visible = false;
			dataGridView1.Columns[13].Visible = false;
			cbmDepartman.DataSource = dto.Departmanlar;
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.DisplayMember = "PozisyonAd";
			cmbPozisyon.ValueMember = "ID";
			cmbPozisyon.SelectedIndex = -1;
			cmbIzinDurum.DataSource = dto.Izinler;
			cmbIzinDurum.DisplayMember = "ID";
			cmbIzinDurum.SelectedIndex = -1;
			if (dto.Departmanlar.Count > 0) combofull = true;

			if (!UserStatic.Admin)
			{
				panel3.Visible = false;
				btnOnayla.Visible = false;
				btnReddet.Visible = false;
			}
		}
		private void FrmIzinListele_Load(object sender, EventArgs e)
		{

			Doldur();

		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			var frm = new FrmIzinBilgileri();
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
			if (detay.IzinID == 0)
			{
				MesajKutusu.MesajGoster("Lütfen izin seçiniz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else if(detay.IzınDurumID==ComboStatic.Onaylandi || detay.IzınDurumID==ComboStatic.Reddedildi)
			{
				MesajKutusu.MesajGoster("Onaylanmış veya reddedilmiş izinler güncellenemez. ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				var frm = new FrmIzinBilgileri();
				this.Hide();//Form gizleme
				frm.isUpdate = true;
				frm.detay = detay;
				frm.ShowDialog();
				this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
				combofull = false;
				Temizle();
				Doldur();
			}
			
			
		}

		private void cbmDepartman_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (combofull)
			{
				int deparatmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
				cmbPozisyon.DataSource = dto.Pozisyonlar.Where(x => x.DepartmanID == deparatmanID).ToList();
			}
		}
		List<IzınDetayDTO> listt = new List<IzınDetayDTO>();
		private void btnAra_Click(object sender, EventArgs e)
		{
			listt = dto.Izinler;
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
			if(rbtnBaslama.Checked)
				listt = listt.Where((x) => x.BaslamaTarihi>=Convert.ToDateTime(dpBaslama.Value)&&
				x.BaslamaTarihi< Convert.ToDateTime(dpBitis.Value)).ToList();
			if (rbtnBitis.Checked)
				listt = listt.Where((x) => x.BitisTarihi >= Convert.ToDateTime(dpBitis.Value) &&
				x.BaslamaTarihi < Convert.ToDateTime(dpBitis.Value)).ToList();
			if (cmbIzinDurum.SelectedIndex != -1)
				listt = listt.Where(x => x.IzınDurumID == Convert.ToInt32(cmbIzinDurum.SelectedValue)).ToList();
			if (txtSure.Text.Trim().Length > 0)
				listt = listt.Where(x => x.Süre==Convert.ToInt32(txtSure.Text)).ToList();
			dataGridView1.DataSource = listt;
		}
		void Temizle()
		{
			txtAdi.Clear();
			txtKullaniciNo.Clear();
			txtSoyadi.Clear();
			cbmDepartman.SelectedIndex = -1;
			cmbPozisyon.DataSource = dto.Pozisyonlar;
			cmbPozisyon.SelectedIndex = -1;
			dataGridView1.DataSource = dto.Izinler;
			rbtnBaslama.Checked = false;
			rbtnBitis.Checked = false;
			txtSure.Clear();
			dpBaslama.Value = DateTime.Today;
			dpBitis.Value = DateTime.Today;
		}
		private void btnTemizle_Click(object sender, EventArgs e)
		{
			Temizle();
		}
		IzınDetayDTO detay = new IzınDetayDTO();
		private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			
			detay.IzinID =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[14].Value);
			detay.BaslamaTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
			detay.BitisTarihi = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
			detay.KullaniciNo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
			detay.Süre = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
			detay.Aciklama =dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
			detay.IzınDurumID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[13].Value);

		}

		private void btnOnayla_Click(object sender, EventArgs e)
		{
			if(detay.IzinID == 0)
			{
				MesajKutusu.MesajGoster("Lütfen izin seçiniz","",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			else
			{
				IzınBLL.IzınGüncelle(detay.IzinID, ComboStatic.Onaylandi);
				MesajKutusu.MesajGoster("Onaylandı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Temizle();
				Doldur();
			}
		}

		private void btnReddet_Click(object sender, EventArgs e)
		{
			if (detay.IzinID == 0)
			{
				MesajKutusu.MesajGoster("Lütfen izin seçiniz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				IzınBLL.IzınGüncelle(detay.IzinID, ComboStatic.Reddedildi);
				MesajKutusu.MesajGoster("Reddedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Temizle();
				Doldur();
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result =  MesajKutusu.MesajGoster("Seçili ögeyi silemk istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(result == DialogResult.Yes)
			{
				if(detay.IzınDurumID == ComboStatic.Onaylandi || detay.IzınDurumID == ComboStatic.Reddedildi)
					MesajKutusu.MesajGoster("Onaylanmış veya reddedilmiş izinleri silemezsiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				else
				{
					IzınBLL.Sil(detay.IzinID);
					MesajKutusu.MesajGoster("Silindi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					combofull = false;
					Temizle();
					Doldur();
				}
			}

		}

		private void btnExel_Click(object sender, EventArgs e)
		{
			ExcelExport.ExportExcel(dataGridView1,"İzin Listesi");
		}
	}
}
