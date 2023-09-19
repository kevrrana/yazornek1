using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazıornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            txtYazSil.Text = "KEVSER RAMAZANOĞLU";
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtYazSil.Text = "";
        }
    }
}
