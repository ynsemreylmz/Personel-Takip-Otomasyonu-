namespace PL
{
	partial class FrmIsBilgileri
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
			this.lblDepartman = new System.Windows.Forms.Label();
			this.cmbPozisyon = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbmDepartman = new System.Windows.Forms.ComboBox();
			this.lblKullaniciNo = new System.Windows.Forms.Label();
			this.txtKullaniciNo = new System.Windows.Forms.TextBox();
			this.lblSoyadi = new System.Windows.Forms.Label();
			this.txtSoyadi = new System.Windows.Forms.TextBox();
			this.lblAdı = new System.Windows.Forms.Label();
			this.txtAdi = new System.Windows.Forms.TextBox();
			this.lblIsDurum = new System.Windows.Forms.Label();
			this.cmbIsDurum = new System.Windows.Forms.ComboBox();
			this.lblBaslik = new System.Windows.Forms.Label();
			this.txtBaslik = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIcerik = new System.Windows.Forms.TextBox();
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
			this.panel1.Location = new System.Drawing.Point(612, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(283, 599);
			this.panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 156);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(283, 443);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblDepartman);
			this.panel2.Controls.Add(this.cmbPozisyon);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.cbmDepartman);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(283, 156);
			this.panel2.TabIndex = 1;
			// 
			// lblDepartman
			// 
			this.lblDepartman.AutoSize = true;
			this.lblDepartman.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartman.ForeColor = System.Drawing.Color.White;
			this.lblDepartman.Location = new System.Drawing.Point(4, 74);
			this.lblDepartman.Name = "lblDepartman";
			this.lblDepartman.Size = new System.Drawing.Size(113, 25);
			this.lblDepartman.TabIndex = 26;
			this.lblDepartman.Text = "Pozisyon";
			// 
			// cmbPozisyon
			// 
			this.cmbPozisyon.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbPozisyon.FormattingEnabled = true;
			this.cmbPozisyon.Location = new System.Drawing.Point(8, 98);
			this.cmbPozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbPozisyon.Name = "cmbPozisyon";
			this.cmbPozisyon.Size = new System.Drawing.Size(257, 33);
			this.cmbPozisyon.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(4, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 25);
			this.label1.TabIndex = 25;
			this.label1.Text = "Departman";
			// 
			// cbmDepartman
			// 
			this.cbmDepartman.Font = new System.Drawing.Font("Verdana", 12F);
			this.cbmDepartman.FormattingEnabled = true;
			this.cbmDepartman.Location = new System.Drawing.Point(8, 39);
			this.cbmDepartman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbmDepartman.Name = "cbmDepartman";
			this.cbmDepartman.Size = new System.Drawing.Size(257, 33);
			this.cbmDepartman.TabIndex = 0;
			this.cbmDepartman.SelectedIndexChanged += new System.EventHandler(this.cbmDepartman_SelectedIndexChanged);
			// 
			// lblKullaniciNo
			// 
			this.lblKullaniciNo.AutoSize = true;
			this.lblKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKullaniciNo.ForeColor = System.Drawing.Color.White;
			this.lblKullaniciNo.Location = new System.Drawing.Point(15, 39);
			this.lblKullaniciNo.Name = "lblKullaniciNo";
			this.lblKullaniciNo.Size = new System.Drawing.Size(146, 25);
			this.lblKullaniciNo.TabIndex = 48;
			this.lblKullaniciNo.Text = "Kullanıcı No";
			// 
			// txtKullaniciNo
			// 
			this.txtKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciNo.Location = new System.Drawing.Point(167, 36);
			this.txtKullaniciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtKullaniciNo.Name = "txtKullaniciNo";
			this.txtKullaniciNo.ReadOnly = true;
			this.txtKullaniciNo.Size = new System.Drawing.Size(257, 32);
			this.txtKullaniciNo.TabIndex = 47;
			// 
			// lblSoyadi
			// 
			this.lblSoyadi.AutoSize = true;
			this.lblSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSoyadi.ForeColor = System.Drawing.Color.White;
			this.lblSoyadi.Location = new System.Drawing.Point(15, 156);
			this.lblSoyadi.Name = "lblSoyadi";
			this.lblSoyadi.Size = new System.Drawing.Size(87, 25);
			this.lblSoyadi.TabIndex = 52;
			this.lblSoyadi.Text = "Soyadı";
			// 
			// txtSoyadi
			// 
			this.txtSoyadi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSoyadi.Location = new System.Drawing.Point(167, 156);
			this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSoyadi.Name = "txtSoyadi";
			this.txtSoyadi.ReadOnly = true;
			this.txtSoyadi.Size = new System.Drawing.Size(257, 32);
			this.txtSoyadi.TabIndex = 50;
			// 
			// lblAdı
			// 
			this.lblAdı.AutoSize = true;
			this.lblAdı.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdı.ForeColor = System.Drawing.Color.White;
			this.lblAdı.Location = new System.Drawing.Point(15, 101);
			this.lblAdı.Name = "lblAdı";
			this.lblAdı.Size = new System.Drawing.Size(49, 25);
			this.lblAdı.TabIndex = 51;
			this.lblAdı.Text = "Adı";
			// 
			// txtAdi
			// 
			this.txtAdi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtAdi.Location = new System.Drawing.Point(167, 97);
			this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAdi.Name = "txtAdi";
			this.txtAdi.ReadOnly = true;
			this.txtAdi.Size = new System.Drawing.Size(257, 32);
			this.txtAdi.TabIndex = 49;
			// 
			// lblIsDurum
			// 
			this.lblIsDurum.AutoSize = true;
			this.lblIsDurum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblIsDurum.ForeColor = System.Drawing.Color.White;
			this.lblIsDurum.Location = new System.Drawing.Point(15, 213);
			this.lblIsDurum.Name = "lblIsDurum";
			this.lblIsDurum.Size = new System.Drawing.Size(132, 25);
			this.lblIsDurum.TabIndex = 54;
			this.lblIsDurum.Text = "İş Durumu";
			// 
			// cmbIsDurum
			// 
			this.cmbIsDurum.Font = new System.Drawing.Font("Verdana", 12F);
			this.cmbIsDurum.FormattingEnabled = true;
			this.cmbIsDurum.Location = new System.Drawing.Point(167, 209);
			this.cmbIsDurum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbIsDurum.Name = "cmbIsDurum";
			this.cmbIsDurum.Size = new System.Drawing.Size(257, 33);
			this.cmbIsDurum.TabIndex = 0;
			// 
			// lblBaslik
			// 
			this.lblBaslik.AutoSize = true;
			this.lblBaslik.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBaslik.ForeColor = System.Drawing.Color.White;
			this.lblBaslik.Location = new System.Drawing.Point(15, 295);
			this.lblBaslik.Name = "lblBaslik";
			this.lblBaslik.Size = new System.Drawing.Size(79, 25);
			this.lblBaslik.TabIndex = 56;
			this.lblBaslik.Text = "Başlık";
			// 
			// txtBaslik
			// 
			this.txtBaslik.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBaslik.Location = new System.Drawing.Point(167, 292);
			this.txtBaslik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBaslik.Name = "txtBaslik";
			this.txtBaslik.Size = new System.Drawing.Size(257, 32);
			this.txtBaslik.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(15, 342);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 25);
			this.label2.TabIndex = 58;
			this.label2.Text = "İçerik";
			// 
			// txtIcerik
			// 
			this.txtIcerik.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtIcerik.Location = new System.Drawing.Point(167, 338);
			this.txtIcerik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtIcerik.Multiline = true;
			this.txtIcerik.Name = "txtIcerik";
			this.txtIcerik.Size = new System.Drawing.Size(423, 139);
			this.txtIcerik.TabIndex = 2;
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
			this.btnKaydet.Location = new System.Drawing.Point(148, 516);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(219, 70);
			this.btnKaydet.TabIndex = 3;
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
			this.btnKapat.Location = new System.Drawing.Point(372, 516);
			this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(219, 70);
			this.btnKapat.TabIndex = 4;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// FrmIsBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(895, 599);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIcerik);
			this.Controls.Add(this.lblBaslik);
			this.Controls.Add(this.txtBaslik);
			this.Controls.Add(this.lblIsDurum);
			this.Controls.Add(this.cmbIsDurum);
			this.Controls.Add(this.lblKullaniciNo);
			this.Controls.Add(this.txtKullaniciNo);
			this.Controls.Add(this.lblSoyadi);
			this.Controls.Add(this.txtSoyadi);
			this.Controls.Add(this.lblAdı);
			this.Controls.Add(this.txtAdi);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmIsBilgileri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmIsBilgileri";
			this.Load += new System.EventHandler(this.FrmIsBilgileri_Load);
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
		private System.Windows.Forms.Label lblDepartman;
		private System.Windows.Forms.ComboBox cmbPozisyon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbmDepartman;
		private System.Windows.Forms.Label lblKullaniciNo;
		private System.Windows.Forms.TextBox txtKullaniciNo;
		private System.Windows.Forms.Label lblSoyadi;
		private System.Windows.Forms.TextBox txtSoyadi;
		private System.Windows.Forms.Label lblAdı;
		private System.Windows.Forms.TextBox txtAdi;
		private System.Windows.Forms.Label lblIsDurum;
		private System.Windows.Forms.ComboBox cmbIsDurum;
		private System.Windows.Forms.Label lblBaslik;
		private System.Windows.Forms.TextBox txtBaslik;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIcerik;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnKapat;
	}
}