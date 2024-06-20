using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace covid19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adddata ad = new adddata();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showreport sr = new showreport();
            sr.ShowDialog();
        }
    }
}
