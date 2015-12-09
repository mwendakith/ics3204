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
    public partial class view_statuses : Form
    {
        public view_statuses()
        {
            InitializeComponent();
        }

        private void view_statuses_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[2]{"id", "status"};
            List<string>[] list = new List<string>[2];
            list = db.Select("statuses", 2, columns);


            //status_list.Items.Add(list[1].Count());

            //status_list.Items.Add(db.Count());
            
            foreach(var pp in list[1]){
               
                status_list.Items.Add(pp);
                statuses_combo.Items.Add(pp);
                //status_list.Items.Add(list[0][2]);
                
               
            }
           

        }

        private void statuses_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // status_list.Items.Add(statuses_combo.SelectedIndex);
            DBconnect db = new DBconnect();
            string[] columns = new string[2] { "id", "status" };
            List<string>[] list = new List<string>[2];
            list = db.Select("statuses", 2, columns);
            status_list.Items.Add(list[0][statuses_combo.SelectedIndex]);

        }

        private void home_btn_Click(object sender, EventArgs e)
        {

            Form1 fo = new Form1();
            this.Hide();
            fo.ShowDialog();
            this.Close();
            
        }

        
    }
}
