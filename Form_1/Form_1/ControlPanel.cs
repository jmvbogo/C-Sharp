using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_1
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            panelContact.Visible = false;
            panelLog.Visible = true;
            btnLogOut.Visible = false;
            btnLogOut.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adds the add contact form to be able to pop up on button click
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PersonSearch temp = new PersonSearch();
            temp.ShowDialog();
            //ShowDialog disables all other windows besides the form window selected
        }

        private void btnEdt_Click(object sender, EventArgs e)
        {
            PersonSearch temp = new PersonSearch();
            temp.ShowDialog();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            PersonSearch temp = new PersonSearch();
            temp.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            lblUsrFdbck.Text = "";

            int intAccLevel = LogIn(txtUsrName.Text, txtPassword.Text);

            if (intAccLevel >= 5 && intAccLevel !=0)
            {
                panelContact.Visible = true;
                panelLog.Visible = false;
                panelLog.Enabled = false;
                    btnLogOut.Visible = true;
                    btnLogOut.Enabled = true;
                    btnSearch.Visible = true;
                    btnSearch.Enabled = true;
                    btnDlt.Visible = true;
                    btnDlt.Enabled = true;
                    btnEdt.Visible = true;
                    btnEdt.Enabled = true;
            }
            else if (intAccLevel < 5 && intAccLevel !=0)
            {
                panelContact.Visible = true;
                panelContact.Enabled = true;
                    btnSearch.Visible = false;
                    btnSearch.Enabled = false;
                    btnDlt.Visible = false;
                    btnDlt.Enabled = false;
                    btnEdt.Visible = false;
                    btnEdt.Enabled = false;

                panelLog.Visible = false;
                panelLog.Enabled = false;
                    btnLogOut.Visible = true;
                    btnLogOut.Enabled = true;
            }
            else
            {
                lblUsrFdbck.Text = "Not a valid Username or Password.";
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            lblUsrFdbck.Text = "";
            txtUsrName.Text = "";
            txtPassword.Text = "";
            btnLogOut.Visible = false;
            btnLogOut.Enabled = true;
            panelContact.Visible = false;
            panelLog.Visible = true;
            panelLog.Enabled = true;

        }


        private int LogIn(string strngUsrName, string strngPsswrd)
        {
            int intAccessLvl = 0;

            SqlDataReader dr;

            SqlCommand cmnd = new SqlCommand();

            string SQLstrng = "SELECT AccessLevel FROM Users WHERE (Username = @Username AND Password = @Password)";

            cmnd.Parameters.AddWithValue("@Username", strngUsrName);
            cmnd.Parameters.AddWithValue("@Password", strngPsswrd);

            SqlConnection kahn = new SqlConnection();
            String kahnstrng = "Server = sql.neit.edu,4500;Database = SE255_JMBogoslawski;User Id = SE255_JMBogoslawski; Password = 001408945;";
            kahn.ConnectionString = kahnstrng;

            cmnd.Connection = kahn;
            cmnd.CommandText = SQLstrng;

            kahn.Open();
            dr = cmnd.ExecuteReader();

            while (dr.Read())
            {
                intAccessLvl = Convert.ToInt32(dr["AccessLevel"].ToString());
            }

            kahn.Close();

            return intAccessLvl;
        }
    }
}
