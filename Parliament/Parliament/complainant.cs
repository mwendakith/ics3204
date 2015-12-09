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
    public partial class complainant : Form
    {
        public complainant()
        {
            InitializeComponent();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            this.Hide();
            fo.ShowDialog();

            this.Close();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string t = con_text.Text.ToString();
            if (t != null)
            {
                string ins = "INSERT INTO complainants (complainant) VALUES ('" + t + "')";
                DBconnect db = new DBconnect();
                db.Insert(ins);
                con_list.Items.Add(t);

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string t = con_text.Text.ToString();
            string c = con_combo.SelectedItem.ToString();

            DBconnect db = new DBconnect();
            string[] columns = new string[2] { "id", "complainant" };
            List<string>[] list = new List<string>[2];
            list = db.Select("complainants", 2, columns);




            if (t != null && c != null)
            {
                string ins = "UPDATE complainants SET complainant='" + t + "' WHERE id='" + list[0][con_combo.SelectedIndex] + "';";

                db.Update(ins);
                // con_list.Items.Add(t);

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string c = con_combo.SelectedItem.ToString();
            if (c != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[2] { "id", "complainant" };
                List<string>[] list = new List<string>[2];
                list = db.Select("complainants", 2, columns);

                db.Delete("complainants", list[0][con_combo.SelectedIndex]);
            }
        }

        private void complainant_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[2] { "id", "complainant" };
            List<string>[] list = new List<string>[2];
            list = db.Select("complainants", 2, columns);

            foreach (var pp in list[1])
            {
                con_combo.Items.Add(pp);
                con_list.Items.Add(pp);

            }
        }

        private void con_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            con_text.Text = con_combo.SelectedItem.ToString();
        }

        
    }
}
