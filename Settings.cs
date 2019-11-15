using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DontScrewAround
{
    public partial class Settings : Form
    {
        int szybkosc;
        int ilosc_kulek;
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                szybkosc = 0;
                ilosc_kulek = 3;
            }
            if (radioButton2.Checked)
            {
                szybkosc = 0;
                ilosc_kulek = 6;

            }
            if (radioButton3.Checked)
            {
                szybkosc = 2;
                ilosc_kulek = 6;
            }

            File.WriteAllText("wynik_IO.txt", szybkosc.ToString() + Environment.NewLine + ilosc_kulek.ToString());
            new Form1().Show();
            this.Close();
        }
    }
}
