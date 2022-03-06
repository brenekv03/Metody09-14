using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "Ahoj 5já jsem 1 matěj12";
            int cifSoucet;
            int cifSoucetLich;
            int cifSoucetSud;
            if (Pocitani.obsahujeCislici(s, out cifSoucet, out cifSoucetLich, out cifSoucetSud)) MessageBox.Show("Obsahuje číslici\nCif Sou. je: " + cifSoucet + "\nCif. Sou. Lich. je: " + cifSoucetLich + "\nCif. Sou. Sud.: " + cifSoucetSud);
            else MessageBox.Show("Neobsahuje číslo");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
