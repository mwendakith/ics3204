using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parliament
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void con_btn_Click(object sender, EventArgs e)
        {
            
            constituency co = new constituency();
            this.Hide();
            co.ShowDialog();
            
            this.Close();

        }

        private void status_btn_Click(object sender, EventArgs e)
        {
            view_statuses vi = new view_statuses();
            this.Hide();
            vi.ShowDialog();
            this.Close();
        }

        private void complainants_btn_Click(object sender, EventArgs e)
        {
            complainant co = new complainant();
            this.Hide();
            co.ShowDialog();
            this.Close();
        }

        private void mps_btn_Click(object sender, EventArgs e)
        {
            mps mp = new mps();
            this.Hide();
            mp.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cases_btn_Click(object sender, EventArgs e)
        {
            cases ca = new cases();
            this.Hide();
            ca.ShowDialog();
            this.Close();
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {
            invoices oo = new invoices();
            this.Hide();
            oo.ShowDialog();
            this.Close();
        }
    }
}
