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
    public partial class cases : Form
    {
        public cases()
        {
            InitializeComponent();
        }

        private void cases_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[2] { "id", "title" };
            List<string>[] list = new List<string>[2];
            list = db.Select("cases", 2, columns);

            foreach (var pp in list[1])
            {
                title_combo.Items.Add(pp);
               
            }

            columns = new string[5] { "id", "constituency_id", "surname", "first_name", "status_id" };
            list = new List<string>[5];
            list = db.Select("mps", 5, columns);

            for (int x = 0; x < list[0].Count(); x++)
            {
                string name = list[2][x] + " " + list[3][x];
                mp_combo.Items.Add(name);
            }

            columns = new string[2] { "id", "verdict" };
            list = new List<string>[2];
            list = db.Select("verdicts", 2, columns);

            foreach (var pp in list[1])
            {
                verdict_combo.Items.Add(pp);

            }

            columns = new string[2] { "id", "state" };
            list = new List<string>[2];
            list = db.Select("case_states", 2, columns);

            foreach (var pp in list[1])
            {
                status_combo.Items.Add(pp);

            }

            columns = new string[2] { "id", "complainant" };
            list = new List<string>[2];
            list = db.Select("complainants", 2, columns);

            foreach (var pp in list[1])
            {
                con_combo.Items.Add(pp);

            }
            pending_txt.Text = db.Count("cases", "status", "1").ToString();

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
            string t = date_text.Text.ToString();
            string y = charge_text.Text.ToString();
            string c = mp_combo.SelectedItem.ToString();
            string a = con_combo.SelectedItem.ToString();
            string b = status_combo.SelectedItem.ToString();
            string d = verdict_combo.SelectedItem.ToString();
            string tit = title_txt.Text.ToString();

            if (t != null && y != null && c != null && tit != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id"};
                List<string>[] list = new List<string>[1];

                list = db.Select("mps", 1, columns);
                string mp_id = list[0][mp_combo.SelectedIndex];

                list = db.Select("complainants", 1, columns);
                string comp_id = list[0][con_combo.SelectedIndex];

                list = db.Select("verdicts", 1, columns);
                string verd_id = list[0][verdict_combo.SelectedIndex];

                list = db.Select("case_states", 1, columns);
                string st_id = list[0][status_combo.SelectedIndex];

                string notes = notes_txt.Text.ToString();

                string ins = "INSERT INTO cases (mp_id, complainant_id, title, date_opened, charge, verdict, status, notes) VALUES ('" + mp_id + "', '" + comp_id + "', '" + tit + "', '" + t + "', '" + y + "', '" + verd_id + "', '" + st_id + "', '" + notes + "')";

                db.Insert(ins);
                // con_list.Items.Add(t + " " + y);

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string t = date_text.Text.ToString();
            string y = charge_text.Text.ToString();
            string c = mp_combo.SelectedItem.ToString();
            string a = con_combo.SelectedItem.ToString();
            string b = status_combo.SelectedItem.ToString();
            string d = verdict_combo.SelectedItem.ToString();
            string tit = title_txt.Text.ToString();

            if (t != null && y != null && c != null && tit != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];

                list = db.Select("cases", 1, columns);
                string tit_id = list[0][title_combo.SelectedIndex];

                list = db.Select("mps", 1, columns);
                string mp_id = list[0][mp_combo.SelectedIndex];

                list = db.Select("complainants", 1, columns);
                string comp_id = list[0][con_combo.SelectedIndex];

                list = db.Select("verdicts", 1, columns);
                string verd_id = list[0][verdict_combo.SelectedIndex];

                list = db.Select("case_states", 1, columns);
                string st_id = list[0][status_combo.SelectedIndex];

                string notes = notes_txt.Text.ToString();

                string ins = "UPDATE cases SET mp_id='" + mp_id + "', complainant_id='" + comp_id + "', title='" + tit + "', date_opened='" + t + "', charge='" + y + "', verdict='" + verd_id + "', status='" + st_id + "', notes='" + notes + "' WHERE id = '" + tit_id + "'";

                db.Update(ins);
                // con_list.Items.Add(t + " " + y);

            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string p = title_combo.SelectedItem.ToString();
            if (p != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("cases", 1, columns);
                string const_id = list[0][title_combo.SelectedIndex];

                db.Delete("cases", const_id);

            }
        }

        private void title_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DBconnect db = new DBconnect();
            string[] columns = new string[1] { "id" };
            List<string>[] list = new List<string>[1];
            list = db.Select("cases", 1, columns);
            string const_id = list[0][title_combo.SelectedIndex];

            date_text.Text = db.select("cases", "date_opened", const_id);
            charge_text.Text = db.select("cases", "charge", const_id);
            notes_txt.Text = db.select("cases", "notes", const_id);
            title_txt.Text = db.select("cases", "title", const_id);

            string mp_id = db.select("cases", "mp_id", const_id);
            mp_combo.Text = db.select("mps", "surname", mp_id) + " " + db.select("mps", "first_name", mp_id);

            string verdict = db.select("cases", "verdict", const_id);
            verdict_combo.Text = db.select("verdicts", "verdict", verdict);

            string complainant = db.select("cases", "complainant_id", const_id);
            con_combo.Text = db.select("complainants", "complainant", verdict);

            string status = db.select("cases", "status", const_id);
            status_combo.Text = db.select("case_states", "state", status);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void mp_cases_btn_Click(object sender, EventArgs e)
        {
            string c = mp_combo.SelectedItem.ToString();

            if (c != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];
                list = db.Select("mps", 1, columns);
                string const_id = list[0][mp_combo.SelectedIndex];

                total_cases_txt.Text = db.Count("cases", "mp_id", const_id).ToString();

            }
        }
    }
}
