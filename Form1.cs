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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        
        }



        private void button1_Click(object sender, EventArgs e)     //przycisk do uruchumienia gry
        {
            String lines = File.ReadAllText("settings_IO.txt");    //odczytuje z pliku jakie są ustawienia gry
            int settings = 0;
            Int32.TryParse(lines, out settings);
            if (settings == 0) {                                   //poziom łatwy - 3 kulki, mala prędkość
                new Form2().Show();
                this.Visible = false;
                    }
            if (settings == 1)                                      //poziom sredni - 3 kulki, duza predkosc
            {
                new Level2().Show();
                this.Visible = false;
            }
            if (settings == 2)                                      //poziom trudny - 6 kulek, srednia predkosc
            {
                new Form2().Show();
                this.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)      //przycisk do wejścia w zakładke wyniki
        {
            new Score().Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)      //przycisk do wejścia w ustawienia
        {
            new Settings().Show();
            this.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)      //przycisk do zamknięcia programu
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); 
        }

    }
}
