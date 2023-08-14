namespace PL
{
	partial class FrmDepartmanBilgileri
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
			this.lblDepartmanAd = new System.Windows.Forms.Label();
			this.txtDepartmanAd = new System.Windows.Forms.TextBox();
			this.btnKaydet = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDepartmanAd
			// 
			this.lblDepartmanAd.AutoSize = true;
			this.lblDepartmanAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDepartmanAd.ForeColor = System.Drawing.Color.White;
			this.lblDepartmanAd.Location = new System.Drawing.Point(32, 80);
			this.lblDepartmanAd.Name = "lblDepartmanAd";
			this.lblDepartmanAd.Size = new System.Drawing.Size(210, 25);
			this.lblDepartmanAd.TabIndex = 0;
			this.lblDepartmanAd.Text = "Departman Adları";
			// 
			// txtDepartmanAd
			// 
			this.txtDepartmanAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtDepartmanAd.Location = new System.Drawing.Point(248, 77);
			this.txtDepartmanAd.Name = "txtDepartmanAd";
			this.txtDepartmanAd.Size = new System.Drawing.Size(258, 32);
			this.txtDepartmanAd.TabIndex = 0;
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
			this.btnKaydet.Location = new System.Drawing.Point(37, 144);
			this.btnKaydet.Name = "btnKaydet";
			this.btnKaydet.Size = new System.Drawing.Size(295, 61);
			this.btnKaydet.TabIndex = 1;
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
			this.btnKapat.Location = new System.Drawing.Point(356, 144);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(150, 61);
			this.btnKapat.TabIndex = 2;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// FrmDepartmanBilgileri
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(535, 289);
			this.Controls.Add(this.btnKapat);
			this.Controls.Add(this.btnKaydet);
			this.Controls.Add(this.txtDepartmanAd);
			this.Controls.Add(this.lblDepartmanAd);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmDepartmanBilgileri";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmDepartmanBilgileri";
			this.Load += new System.EventHandler(this.FrmDepartmanBilgileri_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDepartmanAd;
		private System.Windows.Forms.TextBox txtDepartmanAd;
		private System.Windows.Forms.Button btnKaydet;
		private System.Windows.Forms.Button btnKapat;
	}
}