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
    public partial class GameOver : Form
    {
        int wynik;

        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(int wynik)
        {
            this.wynik = wynik;

            InitializeComponent();
        }


        private void GameOver_MouseClick(object sender, MouseEventArgs e) //wyswietlanie wyniku i zapisywanie go do pliku w celu zapisów najlepszych wyników
        {
            File.AppendAllText("wynik_IO.txt", wynik.ToString() + Environment.NewLine);
            new Form1().Show();
            this.Close();
        }
    }
}
