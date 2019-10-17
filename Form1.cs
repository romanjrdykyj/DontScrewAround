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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) // wychodzenie z trybu pelnoekranowego
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable; // widoczność ramki górnej
                WindowState = FormWindowState.Normal;
                TopMost = false;
            }

            if (e.KeyCode == Keys.F) // wejście w tryb pelnoekranowy
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // widoczność ramki górnej
                WindowState = FormWindowState.Maximized;
                TopMost = true;
            }
        }
    }
}
