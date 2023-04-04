using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HastaneKayit
{
    public partial class sikayetIstek : Form
    {

        public sikayetIstek()
        {
            InitializeComponent();
        }
        Form1 frm1 = new Form1();

        private void gonder_btn_Click(object sender, EventArgs e)
        {
            frm1.uyelerBaglantisi.Open();

            OleDbCommand cmd = new OleDbCommand("insert into Istekler(sikayetTuru,ilgiliAlan,oy,yorum) values ('" + turu_cmbbx.Text.ToString() + "','" + alan_cmbbx.Text + "','" + oy_cmbbx.Text + "','" + kyt_txtbx.Text + "')", frm1.uyelerBaglantisi);
            cmd.ExecuteNonQuery();


            frm1.uyelerBaglantisi.Close();
            MessageBox.Show("İşlem Başarılı");
            this.Close();

            frm1.uyelerBaglantisi.Close();

        }

       /* void uyeBilgileriniGoster()

        {
            frm1.uyelerBaglantisi.Open();

            OleDbCommand cmd = new OleDbCommand("Select * From Uyeler where TC='" + lblTC.Text + "' ", frm1.uyelerBaglantisi);
            cmd.ExecuteNonQuery();
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lblTC.Text = rd["TC"].ToString();
                lblAdSoyad.Text = rd["Adı"].ToString() + " " + rd["Soyadı"].ToString();

            }
            frm1.uyelerBaglantisi.Close();
        }*/

        private void sikayetIstek_Load(object sender, EventArgs e)
        {
        }

       /* private void pictureBox1_Click(object sender, EventArgs e)
        {
            uyeBilgileriniGoster();
        }*/
    }
}
