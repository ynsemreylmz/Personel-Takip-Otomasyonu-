using BLL;
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
	public partial class frmPozisyonListesi : Form
	{
		public frmPozisyonListesi()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			var frm = new FrmPozisyonBilgileri();
			this.Hide();//Form gizleme
			frm.isupdate = false;
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			liste = PozisyonBLL.PozisyonGetir();
			dgwPozisyonList.DataSource = liste;
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			var frm = new FrmPozisyonBilgileri();
			frm.isupdate = true;
			frm.detay = detay;
			this.Hide();//Form gizleme
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			liste = PozisyonBLL.PozisyonGetir();
			dgwPozisyonList.DataSource = liste;
		}
		List<PozisyonDTO> liste = new List<PozisyonDTO>();
		PozisyonDetayDTO detay = new PozisyonDetayDTO();
		void Doldur()
		{
			liste = PozisyonBLL.PozisyonGetir();
			dgwPozisyonList.DataSource = liste;
			dgwPozisyonList.Columns[0].HeaderText = "Departman Adı";
			dgwPozisyonList.Columns[1].Visible = false;
			dgwPozisyonList.Columns[3].Visible = false;
			dgwPozisyonList.Columns[2].HeaderText = "Pozisyon Adı";
		}
		private void frmPozisyonListesi_Load(object sender, EventArgs e)
		{
			Doldur();	
		}

		private void dgwPozisyonList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.ID = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[1].Value);
			detay.DepartmanId = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[3].Value);
			detay.EskiDepartmanId = Convert.ToInt32(dgwPozisyonList.Rows[e.RowIndex].Cells[3].Value);
			detay.PozisyonAd = dgwPozisyonList.Rows[e.RowIndex].Cells[2].Value.ToString();

		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result = MesajKutusu.MesajGoster("Seçili ögeyi silemk istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{


				PozisyonBLL.Sil(detay.ID);
				
				MesajKutusu.MesajGoster("Silindi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				Doldur();

			}
		}
	}
}
