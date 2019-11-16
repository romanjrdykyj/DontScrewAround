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

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String lines = File.ReadAllText("settings_IO.txt");
            int settings = 0;
            Int32.TryParse(lines, out settings);
            if (settings == 0) {
                new Form2().Show();
                this.Visible = false;
                    }
            if (settings == 1)
            {
                new Form2().Show();
                this.Visible = false;
            }
            if (settings == 2)
            {
                new Form2().Show();
                this.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Score().Show();
            this.Visible = false;
        }

        public static int StringtoInt(string s)
        {
            return Int32.Parse(s);
        }
    }
}
