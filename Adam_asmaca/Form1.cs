using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_asmaca
{
    public partial class Form1 : Form
    {
        string[] kelimeler = new string[10];
        char[] harf_dizisi;
        char harf;
        int rast;
        Random rastgele = new Random();

        void reset()
        {
            l1.ForeColor = Color.Gainsboro;
            l2.ForeColor = Color.Gainsboro;
            l3.ForeColor = Color.Gainsboro;
            l4.ForeColor = Color.Gainsboro;
            l5.ForeColor = Color.Gainsboro;
            l6.ForeColor = Color.Gainsboro;

            kelime.Text = "";
            s_harfler.Text = "";

            for(int i=0;i<29;i++)
            buton_panel.Controls.OfType<Button>().ToList()[i].Enabled = true;
        }
        void adam()
        {
            for(int i = 1; i <= 6; i++)
            {
                if (i == 1 && l1.ForeColor == Color.Gainsboro) { l1.ForeColor = Color.Red; break; }
                else if (i == 2 && l2.ForeColor == Color.Gainsboro) { l2.ForeColor = Color.Red; break; }
                else if (i == 3 && l3.ForeColor == Color.Gainsboro) { l3.ForeColor = Color.Red; break; }
                else if (i == 4 && l4.ForeColor == Color.Gainsboro) { l4.ForeColor = Color.Red; break; }
                else if (i == 5 && l5.ForeColor == Color.Gainsboro) { l5.ForeColor = Color.Red; break; }
                else if (i == 6 && l6.ForeColor == Color.Gainsboro)
                {
                    l6.ForeColor = Color.Red;
                    MessageBox.Show("KAYBETTİNİZ...\nKelime : "+ kelimeler[rast]);
                    MessageBox.Show("YENİDEN OYNAMAK İÇİN YENİ OYUN BUTONUNA BASIN...");
                }
            }
        }
        void harf_bul(char krk)
        {
            int sayac = 0,sayac2=0;
            for(int i = 0; i < harf_dizisi.Length; i++)
            {
                if (harf_dizisi[i] == krk)
                {
                    char[] a = kelime.Text.ToString().ToCharArray();
                    a[i * 2] = harf_dizisi[i];
                    kelime.Text = "";
                    for(int j=0;j<a.Length;j++)
                    kelime.Text += a[j].ToString();
                    sayac = 1;
                    for(int j = 0; j < a.Length; j+=2)
                    {
                        if (a[j] == '_') sayac2 = 1;   
                    }
                    if (sayac2 == 0) {
                        MessageBox.Show("TEBRİKLER KAZANDINIZ...");
                        MessageBox.Show("YENİDEN OYNAMAK İÇİN YENİ OYUN BUTONUNA BASIN...");
                        break;
                    }
                }
            }
            if (sayac == 0) adam();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 29; i++)
                buton_panel.Controls.OfType<Button>().ToList()[i].Enabled = false;
            kelimeler[0] = "ARABA";
            kelimeler[1] = "ÜNİVERSİTE";
            kelimeler[2] = "KANTİN";
            kelimeler[3] = "SINIF";
            kelimeler[4] = "DERSLİK";
            kelimeler[5] = "KALEM";
            kelimeler[6] = "PROJEKTÖR";
            var h = new Button() { Width=0, Height=0 };
            buton_panel.Controls.Add(h);
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            harf = Convert.ToChar(((Button)sender).Text);
            ((Button)sender).Enabled = false;
            s_harfler.Text += harf.ToString() + " ";
            harf_bul(harf);
        }

        private void yeni_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 29; i++) buton_panel.Controls.OfType<Button>().ToList()[i].Enabled = true;
            rast = rastgele.Next(0, 7);
            reset();
            harf_dizisi = kelimeler[rast].ToCharArray();
            for (int i = 0; i < harf_dizisi.Length; i++) kelime.Text += "_ ";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
