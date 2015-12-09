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
    public partial class mp_cases : Form
    {
        public string mp_id;
        public mp_cases(string mpid)
        {
            this.mp_id = mpid;
            InitializeComponent();

        }

        private void mp_cases_Load(object sender, EventArgs e)
        {
            DBconnect db = new DBconnect();
            string[] columns = new string[6] {"complainant", "title", "date_opened", "charge", "verdict", "state" };
            List<string>[] list = new List<string>[6];
            string sql = "SELECT complainants.complainant, cases.title, cases.date_opened, cases.charge, verdicts.verdict, case_states.state FROM complainants, cases, verdicts, case_states WHERE complainants.id = cases.complainant_id AND verdicts.id = cases.verdict AND case_states.id=cases.status AND cases.mp_id='" + this.mp_id + "';";

            list = db.Select(6, columns, sql);


            string my_text = "Complainant \t Case Title \t Date Opened \t Charge \t Verdict \t State";
            mp_cases_list.Items.Add(my_text);

            for (int x = 0; x < list[0].Count(); x++)
            {
                string name = list[0][x] + "\t\t " + list[1][x] + "\t " + list[2][x] + "\t " + list[3][x] + "\t " + list[4][x] + "\t " + list[5][x];
                mp_cases_list.Items.Add(name);
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            cases ca = new cases();

            this.Hide();
            ca.ShowDialog();

            this.Close();
        }
    }
}
