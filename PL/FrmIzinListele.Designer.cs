namespace PL
{
	partial class FrmIzinListele
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btnTemizle = new System.Windows.Forms.Button();
			this.btnAra = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSure = new System.Windows.Forms.TextBox();
			this.cmbIzinDurum = new System.Windows.Forms.ComboBox();
			this.dpBaslama = new System.Windows.Forms.DateTimePicker();
			this.dpBitis = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbtnBitis = new System.Windows.Forms.RadioButton();
			this.rbtnBaslama = new System.Windows.Forms.RadioButton();
			this.lblBaşlama = new System.Windows.Forms.Label();
			this.lblBitis = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblDepartman = new System.Windows.Forms.Label();
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbmDepartman = new System.Windows.Forms.ComboBox();
			this.lblSoyadi = new System.Windows.Forms.Label();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.lblAdı = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.lblKullaniciNo = new System.Windows.Forms.Label();
			this.txtKullaniciNo = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnReddet = new System.Windows.Forms.Button();
			this.btnOnayla = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnExel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1067, 224);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btnExel);
			this.panel4.Controls.Add(this.btnTemizle);
			this.panel4.Controls.Add(this.btnAra);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.txtSure);
			this.panel4.Controls.Add(this.cmbIzinDurum);
			this.panel4.Controls.Add(this.dpBaslama);
			this.panel4.Controls.Add(this.dpBitis);
			this.panel4.Controls.Add(this.groupBox1);
			this.panel4.Controls.Add(this.lblBaşlama);
			this.panel4.Controls.Add(this.lblBitis);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel4.Location = new System.Drawing.Point(495, 0);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(572, 224);
			this.panel4.TabIndex = 1;
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
			this.btnTemizle.Location = new System.Drawing.Point(367, 169);
			this.btnTemizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTemizle.Name = "btnTemizle";
			this.btnTemizle.Size = new System.Drawing.Size(193, 32);
			this.btnTemizle.TabIndex = 8;
			this.btnTemizle.Text = "Temizle";
			this.btnTemizle.UseVisualStyleBackColor = false;
			this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
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
			this.btnAra.Location = new System.Drawing.Point(367, 119);
			this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(88, 32);
			this.btnAra.TabIndex = 6;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = false;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(7, 172);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 25);
			this.label3.TabIndex = 34;
			this.label3.Text = "İzin Süresi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(7, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 25);
			this.label2.TabIndex = 62;
			this.label2.Text = "Durum";
			// 
			// txtSure
			// 
			this.txtSure.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSure.Location = new System.Drawing.Point(172, 169);
			this.txtSure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSure.Name = "txtSure";
			this.txtSure.Size = new System.Drawing.Size(188, 32);
			this.txtSure.TabIndex = 7;
			this.txtSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSure_KeyPress);
			// 
			// cmbIzinDurum
			// 
			this.cmbIzinDurum.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbIzinDurum.FormattingEnabled = true;
			this.cmbIzinDurum.Location = new System.Drawing.Point(172, 116);
			this.cmbIzinDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbIzinDurum.Name = "cmbIzinDurum";
			this.cmbIzinDurum.Size = new System.Drawing.Size(188, 33);
			this.cmbIzinDurum.TabIndex = 5;
			// 
			// dpBaslama
			// 
			this.dpBaslama.Font = new System.Drawing.Font("Verdana", 10F);
			this.dpBaslama.Location = new System.Drawing.Point(172, 26);
			this.dpBaslama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dpBaslama.Name = "dpBaslama";
			this.dpBaslama.Size = new System.Drawing.Size(188, 28);
			this.dpBaslama.TabIndex = 3;
			// 
			// dpBitis
			// 
			this.dpBitis.Font = new System.Drawing.Font("Verdana", 10F);
			this.dpBitis.Location = new System.Drawing.Point(172, 71);
			this.dpBitis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dpBitis.Name = "dpBitis";
			this.dpBitis.Size = new System.Drawing.Size(188, 28);
			this.dpBitis.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbtnBitis);
			this.groupBox1.Controls.Add(this.rbtnBaslama);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(367, 12);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(187, 92);
			this.groupBox1.TabIndex = 60;
			this.groupBox1.TabStop = false;
			// 
			// rbtnBitis
			// 
			this.rbtnBitis.AutoSize = true;
			this.rbtnBitis.Location = new System.Drawing.Point(5, 58);
			this.rbtnBitis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtnBitis.Name = "rbtnBitis";
			this.rbtnBitis.Size = new System.Drawing.Size(120, 24);
			this.rbtnBitis.TabIndex = 1;
			this.rbtnBitis.TabStop = true;
			this.rbtnBitis.Text = "Bitiş Tarihi";
			this.rbtnBitis.UseVisualStyleBackColor = true;
			// 
			// rbtnBaslama
			// 
			this.rbtnBaslama.AutoSize = true;
			this.rbtnBaslama.Location = new System.Drawing.Point(5, 16);
			this.rbtnBaslama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rbtnBaslama.Name = "rbtnBaslama";
			this.rbtnBaslama.Size = new System.Drawing.Size(155, 24);
			this.rbtnBaslama.TabIndex = 0;
			this.rbtnBaslama.TabStop = true;
			this.rbtnBaslama.Text = "Başlama Tarihi";
			this.rbtnBaslama.UseVisualStyleBackColor = true;
			// 
			// lblBaşlama
			// 
			this.lblBaşlama.AutoSize = true;
			this.lblBaşlama.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaşlama.ForeColor = System.Drawing.Color.White;
			this.lblBaşlama.Location = new System.Drawing.Point(7, 26);
			this.lblBaşlama.Name = "lblBaşlama";
			this.lblBaşlama.Size = new System.Drawing.Size(106, 25);
			this.lblBaşlama.TabIndex = 58;
			this.lblBaşlama.Text = "Başlama";
			// 
			// lblBitis
			// 
			this.lblBitis.AutoSize = true;
			this.lblBitis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBitis.ForeColor = System.Drawing.Color.White;
			this.lblBitis.Location = new System.Drawing.Point(7, 76);
			this.lblBitis.Name = "lblBitis";
			this.lblBitis.Size = new System.Drawing.Size(62, 25);
			this.lblBitis.TabIndex = 59;
			this.lblBitis.Text = "Bitiş";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lblDepartman);
			this.panel3.Controls.Add(this.cmbPozisyon);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.cbmDepartman);
			this.panel3.Controls.Add(this.lblSoyadi);
			this.panel3.Controls.Add(this.txtSoyadi);
			this.panel3.Controls.Add(this.lblAdı);
			this.panel3.Controls.Add(this.txtAdi);
			this.panel3.Controls.Add(this.lblKullaniciNo);
			this.panel3.Controls.Add(this.txtKullaniciNo);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(495, 224);
			this.panel3.TabIndex = 0;
			// 
			// lblDepartman
			// 
			this.lblDepartman.AutoSize = true;
			this.lblDepartman.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartman.ForeColor = System.Drawing.Color.White;
			this.lblDepartman.Location = new System.Drawing.Point(57, 180);
			this.lblDepartman.Name = "lblDepartman";
			this.lblDepartman.Size = new System.Drawing.Size(113, 25);
			this.lblDepartman.TabIndex = 32;
			this.lblDepartman.Text = "Pozisyon";
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Location = new System.Drawing.Point(223, 176);
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
			this.label1.Location = new System.Drawing.Point(57, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 31;
			this.label1.Text = "Departman";
			// 
			// cbmDepartman
			// 
			this.cbmDepartman.Font = new System.Drawing.Font("Verdana", 12F);
			this.cbmDepartman.FormattingEnabled = true;
			this.cbmDepartman.Location = new System.Drawing.Point(223, 138);
			this.cbmDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbmDepartman.Name = "cbmDepartman";
			this.cbmDepartman.Size = new System.Drawing.Size(257, 33);
			this.cbmDepartman.TabIndex = 3;
			this.cbmDepartman.SelectedIndexChanged += new System.EventHandler(this.cbmDepartman_SelectedIndexChanged);
			// 
			// lblSoyadi
			// 
			this.lblSoyadi.AutoSize = true;
			this.lblSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyadi.ForeColor = System.Drawing.Color.White;
			this.lblSoyadi.Location = new System.Drawing.Point(57, 102);
			this.lblSoyadi.Name = "lblSoyadi";
			this.lblSoyadi.Size = new System.Drawing.Size(87, 25);
			this.lblSoyadi.TabIndex = 30;
			this.lblSoyadi.Text = "Soyadı";
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyadi.Location = new System.Drawing.Point(223, 100);
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
			this.lblAdı.Location = new System.Drawing.Point(57, 64);
			this.lblAdı.Name = "lblAdı";
			this.lblAdı.Size = new System.Drawing.Size(49, 25);
			this.lblAdı.TabIndex = 29;
			this.lblAdı.Text = "Adı";
			// 
			// txtAdi
			// 
			this.txtAdi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdi.Location = new System.Drawing.Point(223, 62);
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
			this.lblKullaniciNo.Location = new System.Drawing.Point(57, 26);
			this.lblKullaniciNo.Name = "lblKullaniciNo";
			this.lblKullaniciNo.Size = new System.Drawing.Size(146, 25);
			this.lblKullaniciNo.TabIndex = 28;
			this.lblKullaniciNo.Text = "Kullanıcı No";
			// 
			// txtKullaniciNo
			// 
			this.txtKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciNo.Location = new System.Drawing.Point(223, 23);
			this.txtKullaniciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtKullaniciNo.Name = "txtKullaniciNo";
			this.txtKullaniciNo.Size = new System.Drawing.Size(257, 32);
			this.txtKullaniciNo.TabIndex = 0;
			this.txtKullaniciNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciNo_KeyPress);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnReddet);
			this.panel2.Controls.Add(this.btnOnayla);
			this.panel2.Controls.Add(this.btnGuncelle);
			this.panel2.Controls.Add(this.btnKapat);
			this.panel2.Controls.Add(this.btnEkle);
			this.panel2.Controls.Add(this.btnSil);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 481);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1067, 123);
			this.panel2.TabIndex = 1;
			// 
			// btnReddet
			// 
			this.btnReddet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnReddet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnReddet.FlatAppearance.BorderSize = 0;
			this.btnReddet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnReddet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnReddet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReddet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnReddet.ForeColor = System.Drawing.Color.White;
			this.btnReddet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReddet.Location = new System.Drawing.Point(199, 34);
			this.btnReddet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReddet.Name = "btnReddet";
			this.btnReddet.Size = new System.Drawing.Size(149, 62);
			this.btnReddet.TabIndex = 1;
			this.btnReddet.Text = "Reddet";
			this.btnReddet.UseVisualStyleBackColor = false;
			this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
			// 
			// btnOnayla
			// 
			this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnOnayla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnOnayla.FlatAppearance.BorderSize = 0;
			this.btnOnayla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnOnayla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnOnayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOnayla.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOnayla.ForeColor = System.Drawing.Color.White;
			this.btnOnayla.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOnayla.Location = new System.Drawing.Point(15, 34);
			this.btnOnayla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOnayla.Name = "btnOnayla";
			this.btnOnayla.Size = new System.Drawing.Size(149, 62);
			this.btnOnayla.TabIndex = 0;
			this.btnOnayla.Text = "Onayla";
			this.btnOnayla.UseVisualStyleBackColor = false;
			this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
			// 
			// btnGuncelle
			// 
			this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnGuncelle.FlatAppearance.BorderSize = 0;
			this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGuncelle.ForeColor = System.Drawing.Color.White;
			this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnGuncelle.Location = new System.Drawing.Point(551, 34);
			this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(149, 62);
			this.btnGuncelle.TabIndex = 3;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
			this.btnKapat.Location = new System.Drawing.Point(901, 34);
			this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(149, 62);
			this.btnKapat.TabIndex = 5;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// btnEkle
			// 
			this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnEkle.FlatAppearance.BorderSize = 0;
			this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.ForeColor = System.Drawing.Color.White;
			this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnEkle.Location = new System.Drawing.Point(375, 34);
			this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(149, 62);
			this.btnEkle.TabIndex = 2;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// btnSil
			// 
			this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.btnSil.FlatAppearance.BorderSize = 0;
			this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
			this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
			this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSil.ForeColor = System.Drawing.Color.White;
			this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSil.Location = new System.Drawing.Point(729, 34);
			this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(149, 62);
			this.btnSil.TabIndex = 4;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 224);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1067, 257);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
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
			this.btnExel.Location = new System.Drawing.Point(471, 119);
			this.btnExel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExel.Name = "btnExel";
			this.btnExel.Size = new System.Drawing.Size(83, 32);
			this.btnExel.TabIndex = 63;
			this.btnExel.Text = "Excel";
			this.btnExel.UseVisualStyleBackColor = false;
			this.btnExel.Click += new System.EventHandler(this.btnExel_Click);
			// 
			// FrmIzinListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(1067, 604);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmIzinListele";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmIzinListele";
			this.Load += new System.EventHandler(this.FrmIzinListele_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnReddet;
		private System.Windows.Forms.Button btnOnayla;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Label lblDepartman;
		private System.Windows.Forms.ComboBox cmbPozisyon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbmDepartman;
		private System.Windows.Forms.Label lblSoyadi;
		private System.Windows.Forms.TextBox txtSoyadi;
		private System.Windows.Forms.Label lblAdı;
		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.Label lblKullaniciNo;
		private System.Windows.Forms.TextBox txtKullaniciNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbIzinDurum;
		private System.Windows.Forms.DateTimePicker dpBaslama;
		private System.Windows.Forms.DateTimePicker dpBitis;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbtnBitis;
		private System.Windows.Forms.RadioButton rbtnBaslama;
		private System.Windows.Forms.Label lblBaşlama;
		private System.Windows.Forms.Label lblBitis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSure;
		private System.Windows.Forms.Button btnTemizle;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.Button btnExel;
	}
}