using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwayDay2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register openForm = new register();
            openForm.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login openForm = new login();
            openForm.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            payment openForm = new payment();
            openForm.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new_event openForm = new new_event();
            openForm.Show();
            Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            communication openForm = new communication();
            openForm.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            billing openForm = new billing();
            openForm.Show();
            Visible = false;
        }
    }
}
