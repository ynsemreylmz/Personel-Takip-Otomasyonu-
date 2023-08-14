using BLL;
using DAL;
using DAL.DAO;
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
	public partial class FrmDepartmanListesi : Form
	{
		public FrmDepartmanListesi()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			var frm = new FrmDepartmanBilgileri();
			this.Hide();//Form gizleme
			frm.isupdate = true;
			frm.detay = detay;
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			liste = DepartmanBLL.DepartmanGetir();
			dgwDepartmanList.DataSource = liste;
		}

		private void btnEkle_Click(object sender, EventArgs e)
		{
			var frm = new FrmDepartmanBilgileri();
			this.Hide();//Form gizleme
			frm.isupdate= false;
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			liste = DepartmanBLL.DepartmanGetir();
			dgwDepartmanList.DataSource = liste;
		}
		List<DEPARTMAN> liste = new List<DEPARTMAN>();
		DEPARTMAN detay = new DEPARTMAN();

		private void FrmDepartmanListesi_Load(object sender, EventArgs e)
		{

			liste = DepartmanBLL.DepartmanGetir();
			dgwDepartmanList.DataSource = liste;
			dgwDepartmanList.Columns[0].Visible = false;
			dgwDepartmanList.Columns[1].HeaderText = "Departman Adı";

		}

		private void dgwDepartmanList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			detay.ID = Convert.ToInt32(dgwDepartmanList.Rows[e.RowIndex].Cells[0].Value);
			detay.DepartmanAd = dgwDepartmanList.Rows[e.RowIndex].Cells[1].Value.ToString();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			DialogResult result = MesajKutusu.MesajGoster("Seçili ögeyi silemk istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{


				DepartmanBLL.Sil(detay.ID);

				MesajKutusu.MesajGoster("Silindi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				liste = DepartmanBLL.DepartmanGetir();
				dgwDepartmanList.DataSource = liste;

			}
		}
	}
}
