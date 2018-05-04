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
    
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        string[] kelimeler2 = new string[20];
        public string kelimeal { get; set; }
        static int indis = 0;

        private void ekle_Click(object sender, EventArgs e)
        {
            kelimeler2[indis] = textBox1.Text;
            kelimeal = kelimeler2[indis];
            indis++;
        }
        
    }
}
