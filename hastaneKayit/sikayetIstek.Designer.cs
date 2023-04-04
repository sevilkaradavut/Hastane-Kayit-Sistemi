namespace HastaneKayit
{
    partial class sikayetIstek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sikayetIstek));
            this.turu_cmbbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alan_cmbbx = new System.Windows.Forms.ComboBox();
            this.kyt_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.oy_cmbbx = new System.Windows.Forms.ComboBox();
            this.gonder_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // turu_cmbbx
            // 
            this.turu_cmbbx.FormattingEnabled = true;
            this.turu_cmbbx.Items.AddRange(new object[] {
            "İstek",
            "Şikayet",
            "Yorum"});
            this.turu_cmbbx.Location = new System.Drawing.Point(299, 222);
            this.turu_cmbbx.Name = "turu_cmbbx";
            this.turu_cmbbx.Size = new System.Drawing.Size(121, 21);
            this.turu_cmbbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Türü   *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlgili Alan *";
            // 
            // alan_cmbbx
            // 
            this.alan_cmbbx.FormattingEnabled = true;
            this.alan_cmbbx.Items.AddRange(new object[] {
            "Doktorlar",
            "Hastane",
            "Sistem",
            "Temizlik",
            "Hasta Bakıcılar",
            "Diğer Konular"});
            this.alan_cmbbx.Location = new System.Drawing.Point(299, 257);
            this.alan_cmbbx.Name = "alan_cmbbx";
            this.alan_cmbbx.Size = new System.Drawing.Size(121, 21);
            this.alan_cmbbx.TabIndex = 3;
            // 
            // kyt_txtbx
            // 
            this.kyt_txtbx.Location = new System.Drawing.Point(169, 336);
            this.kyt_txtbx.Multiline = true;
            this.kyt_txtbx.Name = "kyt_txtbx";
            this.kyt_txtbx.Size = new System.Drawing.Size(281, 157);
            this.kyt_txtbx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(198, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oy *";
            // 
            // oy_cmbbx
            // 
            this.oy_cmbbx.FormattingEnabled = true;
            this.oy_cmbbx.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.oy_cmbbx.Location = new System.Drawing.Point(299, 286);
            this.oy_cmbbx.Name = "oy_cmbbx";
            this.oy_cmbbx.Size = new System.Drawing.Size(121, 21);
            this.oy_cmbbx.TabIndex = 6;
            // 
            // gonder_btn
            // 
            this.gonder_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gonder_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gonder_btn.BackgroundImage")));
            this.gonder_btn.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gonder_btn.Location = new System.Drawing.Point(465, 458);
            this.gonder_btn.Name = "gonder_btn";
            this.gonder_btn.Size = new System.Drawing.Size(75, 35);
            this.gonder_btn.TabIndex = 7;
            this.gonder_btn.Text = "Gönder";
            this.gonder_btn.UseVisualStyleBackColor = false;
            this.gonder_btn.Click += new System.EventHandler(this.gonder_btn_Click);
            // 
            // sikayetIstek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(648, 553);
            this.Controls.Add(this.gonder_btn);
            this.Controls.Add(this.oy_cmbbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kyt_txtbx);
            this.Controls.Add(this.alan_cmbbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turu_cmbbx);
            this.DoubleBuffered = true;
            this.Name = "sikayetIstek";
            this.Text = "İSTEK ŞİKAYET ";
            this.Load += new System.EventHandler(this.sikayetIstek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox turu_cmbbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox alan_cmbbx;
        private System.Windows.Forms.TextBox kyt_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox oy_cmbbx;
        private System.Windows.Forms.Button gonder_btn;
    }
}