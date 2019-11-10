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

        public Boolean stan_menu = false;
        public int licznik_menu = 0;
        public Form1()
        {
            InitializeComponent();

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            

        }
    }
}
