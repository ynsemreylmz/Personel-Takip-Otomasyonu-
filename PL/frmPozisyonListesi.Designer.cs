namespace PL
{
	partial class frmPozisyonListesi
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
			this.btnEkle = new System.Windows.Forms.Button();
			this.btnGuncelle = new System.Windows.Forms.Button();
			this.btnSil = new System.Windows.Forms.Button();
			this.btnKapat = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgwPozisyonList = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwPozisyonList)).BeginInit();
			this.SuspendLayout();
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
			this.btnEkle.Location = new System.Drawing.Point(29, 34);
			this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(149, 62);
			this.btnEkle.TabIndex = 0;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = false;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
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
			this.btnGuncelle.Location = new System.Drawing.Point(224, 34);
			this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGuncelle.Name = "btnGuncelle";
			this.btnGuncelle.Size = new System.Drawing.Size(149, 62);
			this.btnGuncelle.TabIndex = 1;
			this.btnGuncelle.Text = "Güncelle";
			this.btnGuncelle.UseVisualStyleBackColor = false;
			this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
			this.btnSil.Location = new System.Drawing.Point(415, 34);
			this.btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSil.Name = "btnSil";
			this.btnSil.Size = new System.Drawing.Size(149, 62);
			this.btnSil.TabIndex = 2;
			this.btnSil.Text = "Sil";
			this.btnSil.UseVisualStyleBackColor = false;
			this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
			this.btnKapat.Location = new System.Drawing.Point(617, 34);
			this.btnKapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnKapat.Name = "btnKapat";
			this.btnKapat.Size = new System.Drawing.Size(149, 62);
			this.btnKapat.TabIndex = 3;
			this.btnKapat.Text = "Kapat";
			this.btnKapat.UseVisualStyleBackColor = false;
			this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnKapat);
			this.panel1.Controls.Add(this.btnSil);
			this.panel1.Controls.Add(this.btnGuncelle);
			this.panel1.Controls.Add(this.btnEkle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 322);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 128);
			this.panel1.TabIndex = 3;
			// 
			// dgwPozisyonList
			// 
			this.dgwPozisyonList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgwPozisyonList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
			this.dgwPozisyonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPozisyonList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgwPozisyonList.Location = new System.Drawing.Point(0, 0);
			this.dgwPozisyonList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgwPozisyonList.Name = "dgwPozisyonList";
			this.dgwPozisyonList.ReadOnly = true;
			this.dgwPozisyonList.RowHeadersWidth = 51;
			this.dgwPozisyonList.RowTemplate.Height = 24;
			this.dgwPozisyonList.Size = new System.Drawing.Size(800, 322);
			this.dgwPozisyonList.TabIndex = 4;
			this.dgwPozisyonList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPozisyonList_RowEnter);
			// 
			// frmPozisyonListesi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgwPozisyonList);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "frmPozisyonListesi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmPozisyonListesi";
			this.Load += new System.EventHandler(this.frmPozisyonListesi_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwPozisyonList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.Button btnGuncelle;
		private System.Windows.Forms.Button btnSil;
		private System.Windows.Forms.Button btnKapat;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgwPozisyonList;
	}
}