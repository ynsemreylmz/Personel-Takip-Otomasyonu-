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
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void btnKapat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button3_Click(object sender, EventArgs e)
		{	
			if(txtUserNo.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
			{
				MesajKutusu.MesajGoster("Eksik bilgi girdiniz.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				List<PERSONEL> list = PersonelBLL.PersonelGetir(Convert.ToInt32(txtUserNo.Text), txtPassword.Text);
				if(list.Count <= 0) 
				{
					MesajKutusu.MesajGoster("Kullanıcı adı veyaşifre hatalı.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{	
					PERSONEL per = list.First();
					UserStatic.PersonelId = per.ID;
					UserStatic.KullaniciNO = per.UserNo;
					UserStatic.Admin = per.Admin;
					FrmMain frm = new FrmMain();
					this.Hide();//Gizleme
					frm.ShowDialog();
				}
				
			}
			
				



		}
	}
}
