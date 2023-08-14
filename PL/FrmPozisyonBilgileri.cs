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
	public partial class FrmPozisyonBilgileri : Form
	{
		public FrmPozisyonBilgileri()
		{
			InitializeComponent();
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		List<DEPARTMAN> deparatmanlar = new List<DEPARTMAN>();
		public bool isupdate = false;
		public PozisyonDetayDTO detay = new PozisyonDetayDTO();

		private void FrmPozisyonBilgileri_Load(object sender, EventArgs e)
		{	



			deparatmanlar = DAL.DAO.DepartmanDAO.DepartmanGetir();
			cbmDepartman.DataSource = deparatmanlar;	
			cbmDepartman.DisplayMember = "DepartmanAd";
			cbmDepartman.ValueMember = "ID";
			cbmDepartman.SelectedIndex = -1;

			if (isupdate)
			{
				txtPozisyon.Text = detay.PozisyonAd.ToString();
				cbmDepartman.SelectedValue = detay.DepartmanId;
			}

		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(txtPozisyon.Text.Trim() == "")
			{
				MesajKutusu.MesajGoster("Pozisyon adını girini.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
			else if (cbmDepartman.SelectedIndex == -1)
			{
				MesajKutusu.MesajGoster("Departman bilgisini seçiniz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{	

				if(isupdate)
				{
					DialogResult result = MesajKutusu.MesajGoster("Emin misin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result == DialogResult.Yes)
					{
						detay.PozisyonAd = txtPozisyon.Text;
						detay.DepartmanId = Convert.ToInt32(cbmDepartman.SelectedValue);
						bool control = false;
						if(detay.DepartmanId != detay.EskiDepartmanId)
						{
							control = true;
						}
						PozisyonBLL.PozisyonGüncelle(detay, control);
						MesajKutusu.MesajGoster("Güncellendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();

					}
				}

				else
				{
					POZISYON pzs = new POZISYON();
					pzs.PozisyonAd = txtPozisyon.Text;
					pzs.DepartmanID = Convert.ToInt32(cbmDepartman.SelectedValue);
					PozisyonBLL.PozisyonEkle(pzs);
					MesajKutusu.MesajGoster("Kayıt Başarılı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtPozisyon.Clear();
					cbmDepartman.SelectedIndex = -1;
				}

			}
		}
	}
}
