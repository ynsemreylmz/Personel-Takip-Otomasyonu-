namespace PL
{
	partial class FrmPozisyonBilgileri
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
			this.btnKapat = new System.Windows.Forms.Button();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.txtPozisyon = new System.Windows.Forms.TextBox();
			this.lblPozAd = new System.Windows.Forms.Label();
			this.cbmDepartman = new System.Windows.Forms.ComboBox();
			this.DepAd = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.btnKapat.Location = new System.Drawing.Point(373, 136);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(150, 61);
			this.btnKapat.TabIndex = 3;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
			this.btnKaydet.Location = new System.Drawing.Point(54, 136);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(295, 61);
			this.btnKaydet.TabIndex = 2;
			this.btnKaydet.Text = "Kaydet";
			this.btnKaydet.UseVisualStyleBackColor = false;
			this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
			// 
			// txtPozisyon
			// 
			this.txtPozisyon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPozisyon.Location = new System.Drawing.Point(265, 44);
			this.txtPozisyon.Name = "txtPozisyon";
			this.txtPozisyon.Size = new System.Drawing.Size(258, 32);
			this.txtPozisyon.TabIndex = 0;
			// 
			// lblPozAd
			// 
			this.lblPozAd.AutoSize = true;
			this.lblPozAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPozAd.ForeColor = System.Drawing.Color.White;
			this.lblPozAd.Location = new System.Drawing.Point(49, 47);
			this.lblPozAd.Name = "lblPozAd";
			this.lblPozAd.Size = new System.Drawing.Size(157, 25);
			this.lblPozAd.TabIndex = 4;
			this.lblPozAd.Text = "Pozisyon Adı";
			// 
			// cbmDepartman
			// 
			this.cbmDepartman.Font = new System.Drawing.Font("Verdana", 12F);
			this.cbmDepartman.FormattingEnabled = true;
			this.cbmDepartman.Location = new System.Drawing.Point(265, 92);
			this.cbmDepartman.Name = "cbmDepartman";
			this.cbmDepartman.Size = new System.Drawing.Size(258, 33);
			this.cbmDepartman.TabIndex = 1;
			// 
			// DepAd
			// 
			this.DepAd.AutoSize = true;
			this.DepAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.DepAd.ForeColor = System.Drawing.Color.White;
			this.DepAd.Location = new System.Drawing.Point(49, 92);
			this.DepAd.Name = "DepAd";
			this.DepAd.Size = new System.Drawing.Size(180, 25);
			this.DepAd.TabIndex = 8;
			this.DepAd.Text = "Departman Adı";
			// 
			// FrmPozisyonBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(577, 262);
			this.Controls.Add(this.DepAd);
			this.Controls.Add(this.cbmDepartman);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtPozisyon);
			this.Controls.Add(this.lblPozAd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPozisyonBilgileri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmPozisyonBilgileri";
			this.Load += new System.EventHandler(this.FrmPozisyonBilgileri_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.TextBox txtPozisyon;
		private System.Windows.Forms.Label lblPozAd;
		private System.Windows.Forms.ComboBox cbmDepartman;
		private System.Windows.Forms.Label DepAd;
	}
}