using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontScrewAround
{
    public partial class Form2 : Form
    {

        public int ratunek_licznik_odstępu = 100;
        public int ratunek_licznik_widocznosci = 0;


        public Form2()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // wychodzenie z trybu pelnoekranowego
            {
                new Form1().ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

                if (ratunek_licznik_odstępu == 100)
                {
                    Random rnd = new Random();
                    int poczatek = 1;
                    int koniec = 49;
                    int wylosowana = rnd.Next(poczatek, koniec);
                    label1.Text = "Zapamiętaj: " + wylosowana.ToString();
                    ratunek_licznik_odstępu = 0;
                }
                if(ratunek_licznik_widocznosci < 20)
                {
                label1.Visible = true;
                }
                if(ratunek_licznik_widocznosci < 100 & ratunek_licznik_widocznosci > 20)
            {
                label1.Visible = false;
            }
                if(ratunek_licznik_widocznosci == 100)
            {
                ratunek_licznik_widocznosci = 0;
            }
                ratunek_licznik_odstępu += 1;
            ratunek_licznik_widocznosci += 1;
            
        }
    }
}
