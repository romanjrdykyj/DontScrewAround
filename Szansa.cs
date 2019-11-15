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
    public partial class Szansa : Form
    {
        int ostatnia_liczba;
        int wynik;
        Boolean czy_szansa;

        public Szansa(int ostatnia_liczba, int wynik, Boolean czy_szansa)
        {
            this.ostatnia_liczba = ostatnia_liczba;
            this.wynik = wynik;
            this.czy_szansa = czy_szansa;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ostatnia_liczba.ToString())
            {
                new Form2(wynik, czy_szansa).Show();
                this.Close();
            }
            if (textBox1.Text != ostatnia_liczba.ToString())
            {
                new GameOver(wynik).Show();
                this.Close();
            }
        }
    }
}
