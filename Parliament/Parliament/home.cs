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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void con_btn_Click(object sender, EventArgs e)
        {
            
            constituency co = new constituency();
            co.ShowDialog();
            
            this.Dispose();
            this.Close();
            
        }
    }
}
