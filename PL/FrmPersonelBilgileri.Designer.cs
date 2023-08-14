namespace PL
{
	partial class FrmPersonelBilgileri
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
			this.btnKaydet = new System.Windows.Forms.Button();
			this.lblAdres = new System.Windows.Forms.Label();
			this.txtAdres = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblDTarihi = new System.Windows.Forms.Label();
			this.lblDepartman = new System.Windows.Forms.Label();
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbmDepartman = new System.Windows.Forms.ComboBox();
			this.lblMaas = new System.Windows.Forms.Label();
			this.txtMaas = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnKapat = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblSoyadi = new System.Windows.Forms.Label();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.lblAdı = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.chxAdmin = new System.Windows.Forms.CheckBox();
			this.lblsifre = new System.Windows.Forms.Label();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.btnKontrol = new System.Windows.Forms.Button();
			this.lblKullaniciNo = new System.Windows.Forms.Label();
			this.txtKullaniciNo = new System.Windows.Forms.TextBox();
			this.txtBoxFoto = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnKaydet
			// 
			this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnKaydet.FlatAppearance.BorderSize = 0;
			this.btnKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKaydet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKaydet.ForeColor = System.Drawing.Color.White;
			this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnKaydet.Location = new System.Drawing.Point(200, 642);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(219, 70);
			this.btnKaydet.TabIndex = 42;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// lblAdres
			// 
			this.lblAdres.AutoSize = true;
			this.lblAdres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdres.ForeColor = System.Drawing.Color.White;
			this.lblAdres.Location = new System.Drawing.Point(16, 476);
			this.lblAdres.Name = "lblAdres";
			this.lblAdres.Size = new System.Drawing.Size(77, 25);
			this.lblAdres.TabIndex = 52;
			this.lblAdres.Text = "Adres";
			// 
			// txtAdres
			// 
			this.txtAdres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdres.Location = new System.Drawing.Point(200, 476);
			this.txtAdres.Multiline = true;
			this.txtAdres.Name = "txtAdres";
			this.txtAdres.Size = new System.Drawing.Size(609, 139);
			this.txtAdres.TabIndex = 41;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dateTimePicker1.Location = new System.Drawing.Point(188, 411);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(258, 32);
			this.dateTimePicker1.TabIndex = 40;
			// 
			// lblDTarihi
			// 
			this.lblDTarihi.AutoSize = true;
			this.lblDTarihi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDTarihi.ForeColor = System.Drawing.Color.White;
			this.lblDTarihi.Location = new System.Drawing.Point(16, 411);
			this.lblDTarihi.Name = "lblDTarihi";
			this.lblDTarihi.Size = new System.Drawing.Size(164, 25);
			this.lblDTarihi.TabIndex = 51;
			this.lblDTarihi.Text = "Doğum Tarihi";
			// 
			// lblDepartman
			// 
			this.lblDepartman.AutoSize = true;
			this.lblDepartman.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartman.ForeColor = System.Drawing.Color.White;
			this.lblDepartman.Location = new System.Drawing.Point(16, 318);
			this.lblDepartman.Name = "lblDepartman";
			this.lblDepartman.Size = new System.Drawing.Size(113, 25);
			this.lblDepartman.TabIndex = 44;
			this.lblDepartman.Text = "Pozisyon";
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.AccessibleName = "Pozisyon";
			this.cmbPozisyon.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Location = new System.Drawing.Point(188, 310);
			this.cmbPozisyon.Name = "cmbPozisyon";
			this.cmbPozisyon.Size = new System.Drawing.Size(258, 33);
			this.cmbPozisyon.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(16, 266);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 25);
			this.label2.TabIndex = 50;
			this.label2.Text = "Departman";
			// 
			// cbmDepartman
			// 
			this.cbmDepartman.AccessibleName = "Departman";
			this.cbmDepartman.Font = new System.Drawing.Font("Verdana", 12F);
			this.cbmDepartman.FormattingEnabled = true;
			this.cbmDepartman.Location = new System.Drawing.Point(188, 258);
			this.cbmDepartman.Name = "cbmDepartman";
			this.cbmDepartman.Size = new System.Drawing.Size(258, 33);
			this.cbmDepartman.TabIndex = 38;
			this.cbmDepartman.SelectedIndexChanged += new System.EventHandler(this.cbmDepartman_SelectedIndexChanged);
			// 
			// lblMaas
			// 
			this.lblMaas.AutoSize = true;
			this.lblMaas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMaas.ForeColor = System.Drawing.Color.White;
			this.lblMaas.Location = new System.Drawing.Point(16, 210);
			this.lblMaas.Name = "lblMaas";
			this.lblMaas.Size = new System.Drawing.Size(69, 25);
			this.lblMaas.TabIndex = 49;
			this.lblMaas.Text = "Maaş";
			// 
			// txtMaas
			// 
			this.txtMaas.AccessibleName = "Maaşı";
			this.txtMaas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMaas.Location = new System.Drawing.Point(188, 203);
			this.txtMaas.Name = "txtMaas";
			this.txtMaas.Size = new System.Drawing.Size(258, 32);
			this.txtMaas.TabIndex = 37;
			this.txtMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaas_KeyPress);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
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
			this.btnKapat.Location = new System.Drawing.Point(578, 642);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(219, 70);
			this.btnKapat.TabIndex = 43;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(627, 422);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(170, 32);
			this.button1.TabIndex = 36;
			this.button1.Text = "Göz At";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(478, 113);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(319, 291);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 48;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(16, 368);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 25);
			this.label1.TabIndex = 47;
			this.label1.Text = "Fotoğraf";
			// 
			// lblSoyadi
			// 
			this.lblSoyadi.AutoSize = true;
			this.lblSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyadi.ForeColor = System.Drawing.Color.White;
			this.lblSoyadi.Location = new System.Drawing.Point(16, 161);
			this.lblSoyadi.Name = "lblSoyadi";
			this.lblSoyadi.Size = new System.Drawing.Size(87, 25);
			this.lblSoyadi.TabIndex = 46;
			this.lblSoyadi.Text = "Soyadı";
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.AccessibleName = "Soyadı";
			this.txtSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyadi.Location = new System.Drawing.Point(188, 154);
			this.txtSoyadi.Name = "txtSoyadi";
			this.txtSoyadi.Size = new System.Drawing.Size(258, 32);
			this.txtSoyadi.TabIndex = 34;
			// 
			// lblAdı
			// 
			this.lblAdı.AutoSize = true;
			this.lblAdı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdı.ForeColor = System.Drawing.Color.White;
			this.lblAdı.Location = new System.Drawing.Point(16, 112);
			this.lblAdı.Name = "lblAdı";
			this.lblAdı.Size = new System.Drawing.Size(49, 25);
			this.lblAdı.TabIndex = 45;
			this.lblAdı.Text = "Adı";
			// 
			// txtAdi
			// 
			this.txtAdi.AccessibleName = "Adı";
			this.txtAdi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdi.Location = new System.Drawing.Point(188, 105);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.Size = new System.Drawing.Size(258, 32);
			this.txtAdi.TabIndex = 33;
			// 
			// chxAdmin
			// 
			this.chxAdmin.AccessibleName = "";
			this.chxAdmin.AutoSize = true;
			this.chxAdmin.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.chxAdmin.ForeColor = System.Drawing.Color.White;
			this.chxAdmin.Location = new System.Drawing.Point(820, 32);
			this.chxAdmin.Name = "chxAdmin";
			this.chxAdmin.Size = new System.Drawing.Size(89, 26);
			this.chxAdmin.TabIndex = 3;
			this.chxAdmin.Text = "Admin";
			this.chxAdmin.UseVisualStyleBackColor = true;
			// 
			// lblsifre
			// 
			this.lblsifre.AutoSize = true;
			this.lblsifre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblsifre.ForeColor = System.Drawing.Color.White;
			this.lblsifre.Location = new System.Drawing.Point(508, 29);
			this.lblsifre.Name = "lblsifre";
			this.lblsifre.Size = new System.Drawing.Size(64, 25);
			this.lblsifre.TabIndex = 13;
			this.lblsifre.Text = "Şifre";
			// 
			// txtSifre
			// 
			this.txtSifre.AccessibleName = "Şifre";
			this.txtSifre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSifre.Location = new System.Drawing.Point(578, 26);
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.Size = new System.Drawing.Size(191, 32);
			this.txtSifre.TabIndex = 2;
			// 
			// btnKontrol
			// 
			this.btnKontrol.AccessibleName = "";
			this.btnKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnKontrol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnKontrol.FlatAppearance.BorderSize = 0;
			this.btnKontrol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnKontrol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnKontrol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKontrol.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnKontrol.ForeColor = System.Drawing.Color.White;
			this.btnKontrol.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnKontrol.Location = new System.Drawing.Point(374, 21);
			this.btnKontrol.Name = "btnKontrol";
			this.btnKontrol.Size = new System.Drawing.Size(122, 40);
			this.btnKontrol.TabIndex = 1;
			this.btnKontrol.Text = "Kontrol";
			this.btnKontrol.UseVisualStyleBackColor = false;
			this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
			// 
			// lblKullaniciNo
			// 
			this.lblKullaniciNo.AutoSize = true;
			this.lblKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKullaniciNo.ForeColor = System.Drawing.Color.White;
			this.lblKullaniciNo.Location = new System.Drawing.Point(16, 29);
			this.lblKullaniciNo.Name = "lblKullaniciNo";
			this.lblKullaniciNo.Size = new System.Drawing.Size(146, 25);
			this.lblKullaniciNo.TabIndex = 10;
			this.lblKullaniciNo.Text = "Kullanıcı No";
			// 
			// txtKullaniciNo
			// 
			this.txtKullaniciNo.AccessibleName = "Kullanıcı No";
			this.txtKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciNo.Location = new System.Drawing.Point(168, 26);
			this.txtKullaniciNo.Name = "txtKullaniciNo";
			this.txtKullaniciNo.Size = new System.Drawing.Size(191, 32);
			this.txtKullaniciNo.TabIndex = 0;
			this.txtKullaniciNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciNo_KeyPress);
			// 
			// txtBoxFoto
			// 
			this.txtBoxFoto.AccessibleName = "Fotoğraf";
			this.txtBoxFoto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBoxFoto.Location = new System.Drawing.Point(188, 365);
			this.txtBoxFoto.Name = "txtBoxFoto";
			this.txtBoxFoto.ReadOnly = true;
			this.txtBoxFoto.Size = new System.Drawing.Size(258, 32);
			this.txtBoxFoto.TabIndex = 35;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chxAdmin);
			this.panel1.Controls.Add(this.lblsifre);
			this.panel1.Controls.Add(this.txtSifre);
			this.panel1.Controls.Add(this.btnKontrol);
			this.panel1.Controls.Add(this.lblKullaniciNo);
			this.panel1.Controls.Add(this.txtKullaniciNo);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(917, 89);
			this.panel1.TabIndex = 32;
			// 
			// FrmPersonelBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(917, 718);
			this.Controls.Add(this.lblMaas);
			this.Controls.Add(this.txtAdi);
			this.Controls.Add(this.lblAdı);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtSoyadi);
			this.Controls.Add(this.lblAdres);
			this.Controls.Add(this.lblSoyadi);
			this.Controls.Add(this.txtAdres);
			this.Controls.Add(this.txtMaas);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lblDepartman);
			this.Controls.Add(this.lblDTarihi);
			this.Controls.Add(this.cbmDepartman);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.cmbPozisyon);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBoxFoto);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPersonelBilgileri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPersonelBilgileri";
			this.Load += new System.EventHandler(this.FrmPersonelBilgileri_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Label lblAdres;
		private System.Windows.Forms.TextBox txtAdres;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label lblDTarihi;
		private System.Windows.Forms.Label lblDepartman;
		private System.Windows.Forms.ComboBox cmbPozisyon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbmDepartman;
		private System.Windows.Forms.Label lblMaas;
		private System.Windows.Forms.TextBox txtMaas;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblSoyadi;
		private System.Windows.Forms.TextBox txtSoyadi;
		private System.Windows.Forms.Label lblAdı;
		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.CheckBox chxAdmin;
		private System.Windows.Forms.Label lblsifre;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.Button btnKontrol;
		private System.Windows.Forms.Label lblKullaniciNo;
		private System.Windows.Forms.TextBox txtKullaniciNo;
		private System.Windows.Forms.TextBox txtBoxFoto;
		private System.Windows.Forms.Panel panel1;
	}
}