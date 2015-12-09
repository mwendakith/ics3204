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
    public partial class mps : Form
    {
        public mps()
        {
            InitializeComponent();
        }

        private void mps_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[5] { "id", "constituency_id", "surname", "first_name", "status_id" };
            List<string>[] list = new List<string>[5];
            list = db.Select("mps", 5, columns);

            for (int x = 0; x < list[0].Count(); x++)
            {
                string name = list[2][x] + " " + list[3][x];
                con_list.Items.Add(name);
                con_combo.Items.Add(name);
            }

            columns = new string[2] { "id", "constituency" };
            list = new List<string>[2];
            list = db.Select("constituencies", 2, columns);

            foreach (var pp in list[1])
            {
                constituency_combo.Items.Add(pp);
                // con_list.Items.Add(pp);

            }

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
            string t = surname_text.Text.ToString();
            string y = fname_text.Text.ToString();
            //string c = constituency_combo.SelectedItem.ToString();

            if (t != null && y != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[2] { "id", "constituency" };
                List<string>[] list = new List<string>[2];
                list = db.Select("constituencies", 2, columns);

                string ins = "INSERT INTO mps (constituency_id, surname, first_name, status_id) VALUES (" + list[0][constituency_combo.SelectedIndex] + " , '" + t + "', '" + y + "', 1)";
                
                db.Insert(ins);
                con_list.Items.Add(t + " " + y);

            }

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string t = surname_text.Text.ToString();
            string y = fname_text.Text.ToString();
            string c = constituency_combo.SelectedItem.ToString();
            string p = con_combo.SelectedItem.ToString();

            if (t != null && y != null && c != null && p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id"};
                List<string>[] list = new List<string>[1];
                list = db.Select("constituencies", 1, columns);
                string const_id = list[0][constituency_combo.SelectedIndex];

                columns = new string[1] { "id" };
                list = new List<string>[1];
                list = db.Select("mps", 1, columns);

                string ins = "UPDATE mps SET constituency_id=" + const_id + ", surname='" + t + "', first_name= '" + y + "' WHERE id=" + list[0][con_combo.SelectedIndex] + ";";

                db.Update(ins);
                //con_list.Items.Add(t + " " + y);

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string p = con_combo.SelectedItem.ToString();
            if (p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("mps", 1, columns);
                string const_id = list[0][con_combo.SelectedIndex];

                db.Delete("mps", const_id);

            }

        }

        private void cases_btn_Click(object sender, EventArgs e)
        {
            string p = con_combo.SelectedItem.ToString();
            if (p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("mps", 1, columns);
                string const_id = list[0][con_combo.SelectedIndex];

                mp_cases mp_ca = new mp_cases(const_id);
                this.Hide();
                mp_ca.ShowDialog();

                this.Close();
            }
        }

        private void active_btn_Click(object sender, EventArgs e)
        {
            string p = con_combo.SelectedItem.ToString();
            if (p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("mps", 1, columns);
                string const_id = list[0][con_combo.SelectedIndex];

                string ins = "UPDATE mps SET status_id=1 WHERE id=" + const_id + ";";

                db.Update(ins);
               

            }
        }

        private void lost_btn_Click(object sender, EventArgs e)
        {
            string p = con_combo.SelectedItem.ToString();
            if (p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("mps", 1, columns);
                string const_id = list[0][con_combo.SelectedIndex];

                string ins = "UPDATE mps SET status_id=2 WHERE id=" + const_id + ";";

                db.Update(ins);

                


            }

        }

        private void deceased_btn_Click(object sender, EventArgs e)
        {
            string p = con_combo.SelectedItem.ToString();
            if (p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("mps", 1, columns);
                string const_id = list[0][con_combo.SelectedIndex];

                string ins = "UPDATE mps SET status_id=3 WHERE id=" + const_id + ";";

                db.Update(ins);


            }
        }

        private void con_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[1] { "id"};
            List<string>[] list = new List<string>[1];
            list = db.Select("mps", 1, columns);
            string const_id = list[0][con_combo.SelectedIndex];

            surname_text.Text = db.select("mps", "surname", const_id);
            fname_text.Text = db.select("mps", "first_name", const_id);
            string x = db.select("mps", "constituency_id", const_id);

            constituency_combo.Text = db.select("constituencies", "constituency", x);

            string sta = db.select("mps", "status_id", const_id);
            status_text.Text = db.select("statuses", "status", sta);
        }

    }
}
