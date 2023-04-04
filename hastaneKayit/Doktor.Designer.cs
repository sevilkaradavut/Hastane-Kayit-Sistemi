namespace HastaneKayit
{
    partial class Doktor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hakkımda_txtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDoktorAdi = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 346);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.kaydet_btn);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.hakkımda_txtbx);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblKullaniciAdi);
            this.panel2.Location = new System.Drawing.Point(7, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 202);
            this.panel2.TabIndex = 55;
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(177, 172);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(75, 23);
            this.kaydet_btn.TabIndex = 4;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hakkımda_txtbx
            // 
            this.hakkımda_txtbx.Location = new System.Drawing.Point(177, 46);
            this.hakkımda_txtbx.Multiline = true;
            this.hakkımda_txtbx.Name = "hakkımda_txtbx";
            this.hakkımda_txtbx.Size = new System.Drawing.Size(144, 105);
            this.hakkımda_txtbx.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Hakkımda *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Adı Soyadı";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(215, 7);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(14, 20);
            this.lblKullaniciAdi.TabIndex = 29;
            this.lblKullaniciAdi.Text = "-";
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(748, 283);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(65, 60);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCikis.TabIndex = 54;
            this.btnCikis.TabStop = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(464, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(349, 200);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TC Kimlik No";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tarih";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saat";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(568, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Randevularım";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.toolStripStatusLabel1,
            this.lblTarih,
            this.toolStripStatusLabel2,
            this.lblDoktorAdi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSaat.Size = new System.Drawing.Size(118, 17);
            this.lblSaat.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "/";
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(118, 17);
            this.lblTarih.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel2.Text = " - ";
            // 
            // lblDoktorAdi
            // 
            this.lblDoktorAdi.BackColor = System.Drawing.SystemColors.Control;
            this.lblDoktorAdi.Name = "lblDoktorAdi";
            this.lblDoktorAdi.Size = new System.Drawing.Size(86, 17);
            this.lblDoktorAdi.Text = "Giriş Yapılmadı";
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 10;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // Doktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(854, 389);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Doktor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Doktor_FormClosed);
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDoktorAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblTarih;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.PictureBox btnCikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox hakkımda_txtbx;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button kaydet_btn;
    }
}