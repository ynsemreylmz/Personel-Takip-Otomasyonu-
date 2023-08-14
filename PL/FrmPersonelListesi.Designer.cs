namespace PL
{
	partial class FrmPersonelListesi
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTemizle = new System.Windows.Forms.Button();
			this.lblDepartman = new System.Windows.Forms.Label();
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbmDepartman = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblSoyadi = new System.Windows.Forms.Label();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.lblAdı = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.lblKullaniciNo = new System.Windows.Forms.Label();
			this.txtKullaniciNo = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.dgwPozisyonList = new System.Windows.Forms.DataGridView();
			this.btnExel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwPozisyonList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTemizle
			// 
			this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnTemizle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnTemizle.FlatAppearance.BorderSize = 0;
			this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTemizle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTemizle.ForeColor = System.Drawing.Color.White;
			this.btnTemizle.Location = new System.Drawing.Point(593, 105);
			this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(117, 32);
			this.btnTemizle.TabIndex = 5;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = false;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
			// 
			// lblDepartman
			// 
			this.lblDepartman.AutoSize = true;
			this.lblDepartman.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartman.ForeColor = System.Drawing.Color.White;
			this.lblDepartman.Location = new System.Drawing.Point(441, 57);
			this.lblDepartman.Name = "lblDepartman";
			this.lblDepartman.Size = new System.Drawing.Size(113, 25);
			this.lblDepartman.TabIndex = 16;
			this.lblDepartman.Text = "Pozisyon";
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Location = new System.Drawing.Point(593, 53);
			this.cmbPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbPozisyon.Name = "cmbPozisyon";
			this.cmbPozisyon.Size = new System.Drawing.Size(257, 33);
			this.cmbPozisyon.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(441, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Departman";
			// 
			// cbmDepartman
			// 
			this.cbmDepartman.Font = new System.Drawing.Font("Verdana", 12F);
			this.cbmDepartman.FormattingEnabled = true;
			this.cbmDepartman.Location = new System.Drawing.Point(593, 6);
			this.cbmDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbmDepartman.Name = "cbmDepartman";
			this.cbmDepartman.Size = new System.Drawing.Size(257, 33);
			this.cbmDepartman.TabIndex = 3;
			this.cbmDepartman.SelectedIndexChanged += new System.EventHandler(this.cbmDepartman_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnExel);
			this.panel1.Controls.Add(this.btnTemizle);
			this.panel1.Controls.Add(this.lblDepartman);
			this.panel1.Controls.Add(this.cmbPozisyon);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbmDepartman);
			this.panel1.Controls.Add(this.lblSoyadi);
			this.panel1.Controls.Add(this.txtSoyadi);
			this.panel1.Controls.Add(this.lblAdı);
			this.panel1.Controls.Add(this.txtAdi);
			this.panel1.Controls.Add(this.lblKullaniciNo);
			this.panel1.Controls.Add(this.txtKullaniciNo);
			this.panel1.Controls.Add(this.btnAra);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(863, 148);
			this.panel1.TabIndex = 0;
			// 
			// lblSoyadi
			// 
			this.lblSoyadi.AutoSize = true;
			this.lblSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyadi.ForeColor = System.Drawing.Color.White;
			this.lblSoyadi.Location = new System.Drawing.Point(12, 110);
			this.lblSoyadi.Name = "lblSoyadi";
			this.lblSoyadi.Size = new System.Drawing.Size(87, 25);
			this.lblSoyadi.TabIndex = 12;
			this.lblSoyadi.Text = "Soyadı";
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyadi.Location = new System.Drawing.Point(177, 106);
			this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSoyadi.Name = "txtSoyadi";
			this.txtSoyadi.Size = new System.Drawing.Size(257, 32);
			this.txtSoyadi.TabIndex = 2;
			// 
			// lblAdı
			// 
			this.lblAdı.AutoSize = true;
			this.lblAdı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdı.ForeColor = System.Drawing.Color.White;
			this.lblAdı.Location = new System.Drawing.Point(12, 60);
			this.lblAdı.Name = "lblAdı";
			this.lblAdı.Size = new System.Drawing.Size(49, 25);
			this.lblAdı.TabIndex = 10;
			this.lblAdı.Text = "Adı";
			// 
			// txtAdi
			// 
			this.txtAdi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdi.Location = new System.Drawing.Point(177, 57);
			this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.Size = new System.Drawing.Size(257, 32);
			this.txtAdi.TabIndex = 1;
			// 
			// lblKullaniciNo
			// 
			this.lblKullaniciNo.AutoSize = true;
			this.lblKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKullaniciNo.ForeColor = System.Drawing.Color.White;
			this.lblKullaniciNo.Location = new System.Drawing.Point(12, 9);
			this.lblKullaniciNo.Name = "lblKullaniciNo";
			this.lblKullaniciNo.Size = new System.Drawing.Size(146, 25);
			this.lblKullaniciNo.TabIndex = 8;
			this.lblKullaniciNo.Text = "Kullanıcı No";
			// 
			// txtKullaniciNo
			// 
			this.txtKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciNo.Location = new System.Drawing.Point(177, 6);
			this.txtKullaniciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtKullaniciNo.Name = "txtKullaniciNo";
			this.txtKullaniciNo.Size = new System.Drawing.Size(257, 32);
			this.txtKullaniciNo.TabIndex = 0;
			this.txtKullaniciNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciNo_KeyPress);
			// 
			// btnAra
			// 
			this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnAra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnAra.FlatAppearance.BorderSize = 0;
			this.btnAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAra.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAra.ForeColor = System.Drawing.Color.White;
			this.btnAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAra.Location = new System.Drawing.Point(734, 105);
			this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(117, 32);
			this.btnAra.TabIndex = 6;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = false;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// btnKapat
			// 
			this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnKapat.FlatAppearance.BorderSize = 0;
			this.btnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKapat.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKapat.ForeColor = System.Drawing.Color.White;
			this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnKapat.Location = new System.Drawing.Point(659, 12);
			this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(149, 62);
			this.btnKapat.TabIndex = 3;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new System.Drawing.Point(445, 12);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(149, 62);
			this.button2.TabIndex = 2;
			this.button2.Text = "Sil";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.Location = new System.Drawing.Point(237, 12);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(149, 62);
			this.button3.TabIndex = 1;
			this.button3.Text = "Güncelle";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnKapat);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.button4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 534);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(863, 85);
			this.panel2.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button4.Location = new System.Drawing.Point(43, 12);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(149, 62);
			this.button4.TabIndex = 0;
			this.button4.Text = "Ekle";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dgwPozisyonList
			// 
			this.dgwPozisyonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwPozisyonList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.dgwPozisyonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPozisyonList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwPozisyonList.Location = new System.Drawing.Point(0, 148);
			this.dgwPozisyonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgwPozisyonList.MultiSelect = false;
			this.dgwPozisyonList.Name = "dgwPozisyonList";
			this.dgwPozisyonList.ReadOnly = true;
			this.dgwPozisyonList.RowHeadersWidth = 51;
			this.dgwPozisyonList.RowTemplate.Height = 24;
			this.dgwPozisyonList.Size = new System.Drawing.Size(863, 386);
			this.dgwPozisyonList.TabIndex = 17;
			this.dgwPozisyonList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPozisyonList_RowEnter);
			// 
			// btnExel
			// 
			this.btnExel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnExel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnExel.FlatAppearance.BorderSize = 0;
			this.btnExel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnExel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnExel.ForeColor = System.Drawing.Color.White;
			this.btnExel.Location = new System.Drawing.Point(460, 105);
			this.btnExel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExel.Name = "btnExel";
			this.btnExel.Size = new System.Drawing.Size(117, 32);
			this.btnExel.TabIndex = 17;
			this.btnExel.Text = "Excel";
			this.btnExel.UseVisualStyleBackColor = false;
			this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
			// 
			// FrmPersonelListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(863, 619);
			this.Controls.Add(this.dgwPozisyonList);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmPersonelListesi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPersonelListesi";
			this.Load += new System.EventHandler(this.FrmPersonelListesi_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwPozisyonList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Label lblDepartman;
		private System.Windows.Forms.ComboBox cmbPozisyon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbmDepartman;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSoyadi;
		private System.Windows.Forms.TextBox txtSoyadi;
		private System.Windows.Forms.Label lblAdı;
		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.Label lblKullaniciNo;
		private System.Windows.Forms.TextBox txtKullaniciNo;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridView dgwPozisyonList;
		private System.Windows.Forms.Button btnExel;
	}
}