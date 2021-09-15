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
    public partial class Form1 : Form
    {

    
    
        public Form1()
        {
            InitializeComponent();
            btnDelete.Visible = false;
            btnDelete.Enabled = false;
            updatebtn.Visible = false;
            updatebtn.Enabled = false;
            fillStateCmboBox();
        }

        public Form1 (Int32 intPerson_ID)
        {
            InitializeComponent();
            fillStateCmboBox();

            sbmtbtn.Visible = false;
            sbmtbtn.Enabled = false;

            SocialMedia temp = new SocialMedia();
            SqlDataReader dr = temp.findContact(intPerson_ID);

            while (dr.Read())
            {
                frstnmtxt.Text = dr["FirstName"].ToString();
                mdlnmtxt.Text = dr["MiddleName"].ToString();
                lstnmtxt.Text = dr["LastName"].ToString();

                strt1txt.Text = dr["Street1"].ToString();
                strt2txt.Text = dr["Street2"].ToString();
                ctytxt.Text = dr["City"].ToString();

                statetxt.SelectedItem = dr["State"].ToString();
                
                zpcdtxt.Text = dr["Zip"].ToString();

                phnnmbrtxt.Text = dr["Phone"].ToString();
                emladdrstxt.Text = dr["Email"].ToString();

                brthdaypckr.Value = DateTime.Parse(dr["Birthday"].ToString());

                facebooktxt.Text = dr["Facebook"].ToString();
                linkedintxt.Text = dr["Linkedin"].ToString();
                twittertxt.Text = dr["Twitter"].ToString();

                lblID.Text = dr["Person_ID"].ToString();
            }


        }



        //On button click looks threw structured variable
        private void sbmtbtn_Click(object sender, EventArgs e)
        {
            //Calls Class page
            //Person Contact = new Person();
            SocialMedia Contact = new SocialMedia();

            Contact.FirstName = frstnmtxt.Text;
            Contact.MiddleName = mdlnmtxt.Text;
            Contact.LastName = lstnmtxt.Text;
            Contact.Street1 = strt1txt.Text;
            Contact.Street2 = strt2txt.Text;
            Contact.City = ctytxt.Text;
            Contact.State = statetxt.Text;
            Contact.Zip = zpcdtxt.Text;
            Contact.Phone = phnnmbrtxt.Text;
            Contact.Email = emladdrstxt.Text;
            Contact.Birthday = brthdaypckr.Value;
            Contact.Facebook = facebooktxt.Text;
            Contact.Linkedin = linkedintxt.Text;
            Contact.Twitter = twittertxt.Text;
           
            
            
            if (Contact.Feedback.Contains("ERROR:"))
            {

                lblfdbcktxt.Text = Contact.Feedback;
            }
            else
            {
                dsplayyCntct(Contact);

                lblfdbcktxt.Text = Contact.AddSocialMedia();
            }
        }

        public void dsplayyCntct(SocialMedia temp)
        {
            lblfdbcktxt.Text = temp.LastName + ", ";
            lblfdbcktxt.Text += temp.FirstName + ", ";
            lblfdbcktxt.Text += temp.MiddleName + "\n";
            lblfdbcktxt.Text += temp.Street1 + ", ";
            lblfdbcktxt.Text += temp.Street2 + "\n";
            lblfdbcktxt.Text += temp.City + ", ";
            lblfdbcktxt.Text += temp.State + ", ";
            lblfdbcktxt.Text += temp.Zip + "\n";
            lblfdbcktxt.Text += temp.Phone + ", ";
            lblfdbcktxt.Text += temp.Email + "\n";
            lblfdbcktxt.Text += temp.Birthday + "\n";
            lblfdbcktxt.Text += temp.Facebook;
        }

        private void updatebtn_Click_1(object sender, EventArgs e)
        {
            SocialMedia temp = new SocialMedia();

            temp.FirstName = frstnmtxt.Text;
            temp.MiddleName = mdlnmtxt.Text;
            temp.LastName = lstnmtxt.Text;
            temp.Street1 = strt1txt.Text;
            temp.Street2 = strt2txt.Text;
            temp.City = ctytxt.Text;
            temp.State = statetxt.Text;
            temp.Zip = zpcdtxt.Text;
            temp.Phone = phnnmbrtxt.Text;
            temp.Email = emladdrstxt.Text;
            temp.Birthday = brthdaypckr.Value;
            temp.Facebook = facebooktxt.Text;
            temp.Linkedin = linkedintxt.Text;
            temp.Twitter = twittertxt.Text;
            temp.Person_ID = Convert.ToInt32(lblID.Text);

            if (temp.Feedback.Contains("ERROR: "))
            {
                lblfdbcktxt.Text = temp.Feedback;
            }
            else if (temp.FirstName.Length > 0 && temp.LastName.Length > 0)
            {
                Int32 intRcrds = temp.updateCntct();
                lblfdbcktxt.Text = intRcrds.ToString() + " Contacts Updated.";
            }
            else
            {
                //dsplayyCntct(temp); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SocialMedia temp = new SocialMedia();

            Int32 intPerson_ID = Convert.ToInt32(lblID.Text);

            Int32 intRcrds = temp.dltCntct(intPerson_ID);

            lblfdbcktxt.Text = intRcrds.ToString() + " Contacts Deleted.";
        }


        private void fillStateCmboBox()
        {
            SqlDataReader dr = VldtnLbry.fillStateBox();

            while (dr.Read())
            {
                statetxt.Items.Add(dr["StateAbbreviation"].ToString());
            }

            statetxt.Items.Insert(0, "Please pick a state");
            statetxt.SelectedIndex = 0;

           dr.Close();
        }

    }            
}



