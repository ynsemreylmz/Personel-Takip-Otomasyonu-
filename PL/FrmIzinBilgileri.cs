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
	public partial class FrmIzinBilgileri : Form
	{
		public FrmIzinBilgileri()
		{
			InitializeComponent();
		}
		TimeSpan sure = new TimeSpan();
		public bool isUpdate = false;
		public IzınDetayDTO detay = new IzınDetayDTO();
		private void FrmIzinBilgileri_Load(object sender, EventArgs e)
		{
			txtKullaniciNo.Text = UserStatic.KullaniciNO.ToString();
			if (isUpdate)
			{
				dpBaslama.Value = detay.BaslamaTarihi;
				dpBitis.Value = detay.BitisTarihi;
				txtSure.Text = detay.Süre.ToString();
				textBox1.Text = detay.Aciklama.ToString();
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dpBaslama_ValueChanged(object sender, EventArgs e)
		{
			sure = dpBitis.Value.Date - dpBaslama.Value.Date;
			txtSure.Text = sure.TotalDays.ToString();
		}

		private void dpBitis_ValueChanged(object sender, EventArgs e)
		{
			sure = dpBitis.Value.Date - dpBaslama.Value.Date;
			txtSure.Text = sure.TotalDays.ToString();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
			if(txtSure.Text.Trim().Length < 0) 
			{
				MesajKutusu.MesajGoster("Süre boş olmamalı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}
			else if (Convert.ToInt32(txtSure.Text)<=0)
			{
				MesajKutusu.MesajGoster("Geçersiz izin süresi.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else if(textBox1.Text.Trim().Length < 0)
					{
				MesajKutusu.MesajGoster("Açıklama giriniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{

				if(isUpdate)
				{
					DialogResult result = MesajKutusu.MesajGoster("DİKKAT","Emin misiniz?",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if(result == DialogResult.Yes)
					{
						IzınDetayDTO detaydto = new IzınDetayDTO();
						detaydto.IzinID = detay.IzinID;
						detaydto.Aciklama = textBox1.Text;
						detaydto.Süre = Convert.ToInt32(txtSure.Text);
						detaydto.BaslamaTarihi = dpBaslama.Value;
						detaydto.BitisTarihi = dpBitis.Value;
						IzınBLL.IzınGüncelle(detaydto);
						MesajKutusu.MesajGoster("Güncellendi","",MessageBoxButtons.OK,MessageBoxIcon.Information);
						this.Close();
					}

				}
                else
                {
					IZIN iz = new IZIN();
					iz.PersonelID = UserStatic.PersonelId;
					iz.IzinDurumID = 1;
					iz.IzinBaslamaTarihi = dpBaslama.Value;
					iz.IzinBitisTarihi = dpBitis.Value;
					iz.Sure = Convert.ToInt32(sure.TotalDays);
					iz.Aciklama = textBox1.Text;
					IzınBLL.IzınEkle(iz);
					MesajKutusu.MesajGoster("İzin eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dpBaslama.Value = DateTime.Today;
					dpBitis.Value = DateTime.Today;
					txtSure.Clear();
					textBox1.Clear();
				}


               
			}
		}
	}
}
