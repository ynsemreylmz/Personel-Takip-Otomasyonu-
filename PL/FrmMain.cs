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

namespace PL
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnPersonel_Click(object sender, EventArgs e)
		{
			if (!UserStatic.Admin)
			{
				FrmPersonelBilgileri frm = new FrmPersonelBilgileri();
				PersonelDTO dto = new PersonelDTO();
				dto = PersonelBLL.GetAll();
				PersonelDetayDTO detay = new PersonelDetayDTO();
				detay = dto.Personeller.First(x => x.PersonelId == UserStatic.PersonelId);
				frm.isUpdate = true;
				frm.detay = detay;
				frm.ShowDialog();
				this.Visible = true; 



			}
			else
			{
				FrmPersonelListesi frm = new FrmPersonelListesi();
				this.Hide();//Form gizleme
				frm.ShowDialog();
				this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
			}
			
		}

		private void btnIsler_Click(object sender, EventArgs e)
		{
			var frm = new FrmIsListesi();
			this.Hide();//Form gizleme
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
		}

		private void btnMaas_Click(object sender, EventArgs e)
		{
			var frm = new FrmMaasListele();
			this.Hide();//Form gizleme
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
		}

		private void btnIzin_Click(object sender, EventArgs e)
		{
			var frm = new FrmIzinListele();
			this.Hide();//Form gizleme
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
		}

		private void btnDepartman_Click(object sender, EventArgs e)
		{
			var frm = new FrmDepartmanListesi();
			this.Hide();//Form gizleme
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
		}

		private void btnPozisyon_Click(object sender, EventArgs e)
		{
			var frm = new frmPozisyonListesi();
			this.Hide();//Form gizleme
			frm.ShowDialog();
			this.Visible = true;//Personel sayfası kapanınca menü görünür olcak
		}

		private void btnOturumKapat_Click(object sender, EventArgs e)
		{
			var frm = new FrmLogin();
			this.Hide();
			frm.ShowDialog();
			this.Visible = true;	
		}

		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{
			if (!UserStatic.Admin)
			{
				btnDepartman.Visible = false;
				btnPozisyon.Visible = false;

				btnOturumKapat.Location = new Point(148, 166);
				btnCikis.Location = new Point(281, 166);
				
			}
		}
	}
}
