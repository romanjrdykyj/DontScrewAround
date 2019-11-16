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
        int wybor_poziomu;
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                wybor_poziomu = 0;
            }
            if (radioButton2.Checked)
            {
                wybor_poziomu = 1;

            }
            if (radioButton3.Checked)
            {
                wybor_poziomu = 2;
            }

            File.WriteAllText("settings_IO.txt", wybor_poziomu.ToString());
            new Form1().Show();
            this.Close();
        }
    }
}
