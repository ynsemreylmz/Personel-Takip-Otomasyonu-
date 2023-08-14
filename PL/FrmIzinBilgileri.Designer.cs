namespace PL
{
	partial class FrmIzinBilgileri
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
			this.lblKullaniciNo = new System.Windows.Forms.Label();
			this.txtKullaniciNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dpBaslama = new System.Windows.Forms.DateTimePicker();
			this.dpBitis = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSure = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblKullaniciNo
			// 
			this.lblKullaniciNo.AutoSize = true;
			this.lblKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblKullaniciNo.ForeColor = System.Drawing.Color.White;
			this.lblKullaniciNo.Location = new System.Drawing.Point(29, 46);
			this.lblKullaniciNo.Name = "lblKullaniciNo";
			this.lblKullaniciNo.Size = new System.Drawing.Size(146, 25);
			this.lblKullaniciNo.TabIndex = 18;
			this.lblKullaniciNo.Text = "Kullanıcı No";
			// 
			// txtKullaniciNo
			// 
			this.txtKullaniciNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtKullaniciNo.Location = new System.Drawing.Point(195, 43);
			this.txtKullaniciNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtKullaniciNo.Name = "txtKullaniciNo";
			this.txtKullaniciNo.ReadOnly = true;
			this.txtKullaniciNo.Size = new System.Drawing.Size(257, 32);
			this.txtKullaniciNo.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(29, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 25);
			this.label1.TabIndex = 19;
			this.label1.Text = "İzin Başlama";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(29, 175);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 25);
			this.label2.TabIndex = 20;
			this.label2.Text = "İzin Bitiş";
			// 
			// dpBaslama
			// 
			this.dpBaslama.Font = new System.Drawing.Font("Verdana", 10F);
			this.dpBaslama.Location = new System.Drawing.Point(195, 111);
			this.dpBaslama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dpBaslama.Name = "dpBaslama";
			this.dpBaslama.Size = new System.Drawing.Size(257, 28);
			this.dpBaslama.TabIndex = 0;
			this.dpBaslama.ValueChanged += new System.EventHandler(this.dpBaslama_ValueChanged);
			// 
			// dpBitis
			// 
			this.dpBitis.Font = new System.Drawing.Font("Verdana", 10F);
			this.dpBitis.Location = new System.Drawing.Point(195, 167);
			this.dpBitis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dpBitis.Name = "dpBitis";
			this.dpBitis.Size = new System.Drawing.Size(257, 28);
			this.dpBitis.TabIndex = 1;
			this.dpBitis.ValueChanged += new System.EventHandler(this.dpBitis_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(29, 242);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 25);
			this.label3.TabIndex = 51;
			this.label3.Text = "İzin Süre";
			// 
			// txtSure
			// 
			this.txtSure.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSure.Location = new System.Drawing.Point(195, 239);
			this.txtSure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSure.Name = "txtSure";
			this.txtSure.ReadOnly = true;
			this.txtSure.Size = new System.Drawing.Size(257, 32);
			this.txtSure.TabIndex = 52;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox1.Location = new System.Drawing.Point(195, 299);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(460, 147);
			this.textBox1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(29, 299);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 25);
			this.label4.TabIndex = 53;
			this.label4.Text = "Açıklama";
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
			this.btnKaydet.Location = new System.Drawing.Point(333, 479);
			this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(149, 62);
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
			this.btnKapat.Location = new System.Drawing.Point(507, 479);
			this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(149, 62);
			this.btnKapat.TabIndex = 4;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// FrmIzinBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(688, 554);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSure);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dpBaslama);
			this.Controls.Add(this.dpBitis);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblKullaniciNo);
			this.Controls.Add(this.txtKullaniciNo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmIzinBilgileri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmIzinBilgileri";
			this.Load += new System.EventHandler(this.FrmIzinBilgileri_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblKullaniciNo;
		private System.Windows.Forms.TextBox txtKullaniciNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dpBaslama;
		private System.Windows.Forms.DateTimePicker dpBitis;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSure;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnKapat;
	}
}