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
    public partial class Score : Form
    {
        public Score() //pobieranie danych z pliku, porządkowanie ich od najwiekszej od najmniejszej i wsywietlanie TOP5 wyników
        {
            InitializeComponent();

            String[] lines = { "0", "0", "0", "0", "0" };
            lines = File.ReadAllLines("wynik_IO.txt");
            int[] wyniki;
            wyniki = Array.ConvertAll(lines, new Converter<string, int>(StringtoInt));
            Array.Sort(wyniki);
            Array.Reverse(wyniki);

            label2.Text = "TOP1: " + wyniki[0];
            label3.Text = "TOP2: " + wyniki[1];
            label4.Text = "TOP3: " + wyniki[2];
            label5.Text = "TOP4: " + wyniki[3];
            label6.Text = "TOP5: " + wyniki[4];


        }

        public static int StringtoInt(string s)
        {
            return Int32.Parse(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            new Form1().Show();
        }
    }
}
