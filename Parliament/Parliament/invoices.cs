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
    public partial class invoices : Form
    {
        public invoices()
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

        private void invoices_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[5] { "id", "constituency_id", "surname", "first_name", "status_id" };
            List<string>[] list = new List<string>[5];
            list = db.Select("mps", 5, columns);

            for (int x = 0; x < list[0].Count(); x++)
            {
                string name = list[2][x] + " " + list[3][x];
                mp_combo.Items.Add(name);
            }

            reason_combo.Items.Add("Prayers");
            reason_combo.Items.Add("Get-togethers");
            reason_combo.Items.Add("Fund Raising");

            columns = new string[1] { "id" };
            list = new List<string>[1];
            list = db.Select("invoices", 1, columns);

            foreach (var pp in list[0])
            {
                invoice_combo.Items.Add(pp);
                
            }

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = mp_combo.Text.ToString();
            b = amount_txt.Text.ToString();
            c = reason_combo.Text.ToString();

            if (a != null && b != null && c != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];

                list = db.Select("mps", 1, columns);
                string mp_id = list[0][mp_combo.SelectedIndex];

                string ins = "INSERT INTO invoices(mp_id, amount, reason) VALUES('" + mp_id + "', '" + b + "','" + c + "')";

                db.Insert(ins);
            }

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = mp_combo.Text.ToString();
            b = amount_txt.Text.ToString();
            c = reason_combo.Text.ToString();

            if (a != null && b != null && c != null)
            {
                DBconnect db = new DBconnect();
                string[] columns = new string[1] { "id" };
                List<string>[] list = new List<string>[1];

                list = db.Select("mps", 1, columns);
                string mp_id = list[0][mp_combo.SelectedIndex];

                string ins = "UPDATE invoices SET mp_id='" + mp_id + "', amount='" + b + "', reason='" + c + "' WHERE id=" + invoice_combo.Text.ToString();

                db.Insert(ins);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string a = invoice_combo.Text.ToString();
            if (a != null)
            {
                DBconnect db = new DBconnect();
                db.Delete("invoices", invoice_combo.Text.ToString());
            }

        }

        private void invoice_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = invoice_combo.Text.ToString();
            if (a != null)
            {
                DBconnect db = new DBconnect();
                string mpid =  db.select("invoices", "mp_id", a);
                amount_txt.Text = db.select("invoices", "amount", a);
                reason_combo.Text = db.select("invoices", "reason", a);
                mp_combo.Text = db.select("mps", "surname", mpid) + " " + db.select("mps", "first_name", mpid);
            }
        }
    }
}
