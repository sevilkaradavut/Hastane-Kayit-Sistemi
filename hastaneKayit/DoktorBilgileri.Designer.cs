namespace HastaneKayit
{
    partial class DoktorBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorBilgileri));
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(217, 123);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(28, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Doktor Adı ve Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(28, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Parolası";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(217, 156);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 0;
            // 
            // DoktorBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 365);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtAdSoyad);
            this.DoubleBuffered = true;
            this.Name = "DoktorBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DoktorBilgileri";
            this.Load += new System.EventHandler(this.DoktorBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtParola;
    }
}