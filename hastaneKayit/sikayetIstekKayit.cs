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
    public partial class sikayetIstekKayit : Form
    {
        public sikayetIstekKayit()
        {
            InitializeComponent();
        }

        Form1 frm1 = new Form1();


        

        private void sikayetIstekKayit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastaneBilgileriDataSet.Istekler' table. You can move, or remove it, as needed.
            YorumlariGetir();
            YorumSayisiHesapla();
        }

      

      
        void YorumlariGetir()
        {
            listView1.Items.Clear();
            int i = 0;
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Istekler", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    listView1.Items.Add(rd["sikayetTuru"].ToString());
                    listView1.Items[i].SubItems.Add(rd["ilgiliAlan"].ToString());
                    listView1.Items[i].SubItems.Add(rd["oy"].ToString());
                    listView1.Items[i].SubItems.Add(rd["yorum"].ToString());
                    i++;
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception)
            {

            }
        }
        int yorum_sayisi = 0;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sikayetTuru = "";
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                sikayetTuru = itm.SubItems[0].Text;
            }


            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Istekler where sikayetTuru='" + sikayetTuru + "'", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    numericUpDown1.Value = int.Parse(rd["ban"].ToString());
                }
                frm1.uyelerBaglantisi.Close();
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                if (hata.Message == "Input string was not in a correct format.")
                {
                    numericUpDown1.Value = 0;
                }
                else
                {
                    MessageBox.Show(hata.Message);
                }

            }
        }
        void YorumSayisiHesapla()
        {
            try
            {
                frm1.uyelerBaglantisi.Open();
                OleDbCommand cmd = new OleDbCommand("Select * From Istekler", frm1.uyelerBaglantisi);
                cmd.ExecuteNonQuery();
                OleDbDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    yorum_sayisi++;
                }
                frm1.uyelerBaglantisi.Close();
                lblYorumSayisi.Text = "Sistemde " + yorum_sayisi + " Adet Yorum Bulunmaktadır";
            }
            catch (Exception hata)
            {
                frm1.uyelerBaglantisi.Close();
                MessageBox.Show(hata.Message);
            }
        }
    }
}

  
