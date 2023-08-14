using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using KaranlikTemaMesajKutusu;

namespace PL
{
	public partial class FrmDepartmanBilgileri : Form
	{
		public FrmDepartmanBilgileri()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if (txtDepartmanAd.Text.ToString().Trim() == "")
			{
				MesajKutusu.MesajGoster("Lütfen departman adını giriniz","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else
			{	

				DEPARTMAN dpt = new DEPARTMAN();
				if (isupdate)
				{
					DialogResult result = MesajKutusu.MesajGoster("Emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result == DialogResult.Yes)
					{
						dpt.DepartmanAd = txtDepartmanAd.Text;
						dpt.ID = detay.ID;
						DepartmanBLL.DepartmanGüncelle(dpt);
						MesajKutusu.MesajGoster("Departman başarıyla Güncellendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();

					}
				}
				else
				{
					dpt.DepartmanAd = txtDepartmanAd.Text;
					DepartmanBLL.DepartmanEkle(dpt);
					txtDepartmanAd.Clear();
					MesajKutusu.MesajGoster("Departman başarıyla eklendi.", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			
			
		}
		public bool isupdate = false;
		public DEPARTMAN detay = new DEPARTMAN();

		private void FrmDepartmanBilgileri_Load(object sender, EventArgs e)
		{
			if(isupdate)
			{
				txtDepartmanAd.Text = detay.DepartmanAd;

			}
		}
	}
}
