namespace PL
{
	partial class FrmMaasBilgileri
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbmDepartman = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			this.lblDepartman = new System.Windows.Forms.Label();
			this.lblSoyadi = new System.Windows.Forms.Label();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.lblAdı = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.lblKullaniciNo = new System.Windows.Forms.Label();
			this.txtKullaniciNo = new System.Windows.Forms.TextBox();
			this.lblMaas = new System.Windows.Forms.Label();
			this.txtMaas = new System.Windows.Forms.TextBox();
			this.lblTarih = new System.Windows.Forms.Label();
			this.txtYil = new System.Windows.Forms.TextBox();
			this.cmbAy = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(454, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(341, 554);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 256);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(341, 298);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.cbmDepartman);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cmbPozisyon);
			this.panel2.Controls.Add(this.lblDepartman);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(341, 256);
			this.panel2.TabIndex = 0;
			// 
			// cbmDepartman
			// 
			this.cbmDepartman.Font = new System.Drawing.Font("Verdana", 12F);
			this.cbmDepartman.FormattingEnabled = true;
			this.cbmDepartman.Location = new System.Drawing.Point(23, 50);
			this.cbmDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbmDepartman.Name = "cbmDepartman";
			this.cbmDepartman.Size = new System.Drawing.Size(257, 33);
			this.cbmDepartman.TabIndex = 0;
			this.cbmDepartman.SelectedIndexChanged += new System.EventHandler(this.cbmDepartman_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(19, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 27;
			this.label1.Text = "Departman";
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Location = new System.Drawing.Point(23, 140);
			this.cmbPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbPozisyon.Name = "cmbPozisyon";
			this.cmbPozisyon.Size = new System.Drawing.Size(257, 33);
			this.cmbPozisyon.TabIndex = 1;
			// 
			// lblDepartman
			// 
			this.lblDepartman.AutoSize = true;
			this.lblDepartman.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartman.ForeColor = System.Drawing.Color.White;
			this.lblDepartman.Location = new System.Drawing.Point(19, 107);
			this.lblDepartman.Name = "lblDepartman";
			this.lblDepartman.Size = new System.Drawing.Size(113, 25);
			this.lblDepartman.TabIndex = 28;
			this.lblDepartman.Text = "Pozisyon";
			// 
			// lblSoyadi
			// 
			this.lblSoyadi.AutoSize = true;
			this.lblSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyadi.ForeColor = System.Drawing.Color.White;
			this.lblSoyadi.Location = new System.Drawing.Point(15, 98);
			this.lblSoyadi.Name = "lblSoyadi";
			this.lblSoyadi.Size = new System.Drawing.Size(87, 25);
			this.lblSoyadi.TabIndex = 24;
			this.lblSoyadi.Text = "Soyadı";
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyadi.Location = new System.Drawing.Point(180, 96);
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
			this.lblAdı.Location = new System.Drawing.Point(15, 60);
			this.lblAdı.Name = "lblAdı";
			this.lblAdı.Size = new System.Drawing.Size(49, 25);
			this.lblAdı.TabIndex = 23;
			this.lblAdı.Text = "Adı";
			// 
			// txtAdi
			// 
			this.txtAdi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdi.Location = new System.Drawing.Point(180, 58);
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
			this.lblKullaniciNo.Location = new System.Drawing.Point(15, 22);
			this.lblKullaniciNo.Name = "lblKullaniciNo";
			this.lblKullaniciNo.Size = new System.Drawing.Size(146, 25);
			this.lblKullaniciNo.TabIndex = 22;
			this.lblKullaniciNo.Text = "Kullanıcı No";
			// 
			// txtKullaniciNo
			// 
			this.txtKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciNo.Location = new System.Drawing.Point(180, 20);
			this.txtKullaniciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtKullaniciNo.Name = "txtKullaniciNo";
			this.txtKullaniciNo.Size = new System.Drawing.Size(257, 32);
			this.txtKullaniciNo.TabIndex = 0;
			// 
			// lblMaas
			// 
			this.lblMaas.AutoSize = true;
			this.lblMaas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMaas.ForeColor = System.Drawing.Color.White;
			this.lblMaas.Location = new System.Drawing.Point(8, 138);
			this.lblMaas.Name = "lblMaas";
			this.lblMaas.Size = new System.Drawing.Size(69, 25);
			this.lblMaas.TabIndex = 51;
			this.lblMaas.Text = "Maaş";
			// 
			// txtMaas
			// 
			this.txtMaas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtMaas.Location = new System.Drawing.Point(180, 135);
			this.txtMaas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMaas.Name = "txtMaas";
			this.txtMaas.Size = new System.Drawing.Size(257, 32);
			this.txtMaas.TabIndex = 3;
			// 
			// lblTarih
			// 
			this.lblTarih.AutoSize = true;
			this.lblTarih.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTarih.ForeColor = System.Drawing.Color.White;
			this.lblTarih.Location = new System.Drawing.Point(8, 182);
			this.lblTarih.Name = "lblTarih";
			this.lblTarih.Size = new System.Drawing.Size(105, 25);
			this.lblTarih.TabIndex = 53;
			this.lblTarih.Text = "Maaş Yıl";
			// 
			// txtYil
			// 
			this.txtYil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtYil.Location = new System.Drawing.Point(180, 174);
			this.txtYil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtYil.Name = "txtYil";
			this.txtYil.Size = new System.Drawing.Size(257, 32);
			this.txtYil.TabIndex = 4;
			// 
			// cmbAy
			// 
			this.cmbAy.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbAy.FormattingEnabled = true;
			this.cmbAy.Location = new System.Drawing.Point(180, 213);
			this.cmbAy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbAy.Name = "cmbAy";
			this.cmbAy.Size = new System.Drawing.Size(257, 33);
			this.cmbAy.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(8, 218);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 25);
			this.label2.TabIndex = 55;
			this.label2.Text = "Maaş Ay";
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
			this.btnKaydet.Location = new System.Drawing.Point(0, 256);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(439, 98);
			this.btnKaydet.TabIndex = 6;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
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
			this.btnKapat.Location = new System.Drawing.Point(220, 470);
			this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(219, 70);
			this.btnKapat.TabIndex = 7;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// FrmMaasBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(795, 554);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.cmbAy);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblTarih);
			this.Controls.Add(this.txtYil);
			this.Controls.Add(this.lblMaas);
			this.Controls.Add(this.txtMaas);
			this.Controls.Add(this.lblSoyadi);
			this.Controls.Add(this.txtSoyadi);
			this.Controls.Add(this.lblAdı);
			this.Controls.Add(this.txtAdi);
			this.Controls.Add(this.lblKullaniciNo);
			this.Controls.Add(this.txtKullaniciNo);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmMaasBilgileri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "FrmMaasBilgileri";
			this.Load += new System.EventHandler(this.FrmMaasBilgileri_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblSoyadi;
		private System.Windows.Forms.TextBox txtSoyadi;
		private System.Windows.Forms.Label lblAdı;
		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.Label lblKullaniciNo;
		private System.Windows.Forms.TextBox txtKullaniciNo;
		private System.Windows.Forms.Label lblDepartman;
		private System.Windows.Forms.ComboBox cmbPozisyon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbmDepartman;
		private System.Windows.Forms.Label lblMaas;
		private System.Windows.Forms.TextBox txtMaas;
		private System.Windows.Forms.Label lblTarih;
		private System.Windows.Forms.TextBox txtYil;
		private System.Windows.Forms.ComboBox cmbAy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnKapat;
	}
}