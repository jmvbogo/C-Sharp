using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Contact_Manager_Form
{


        public partial class Form1 : Form
        {

        //Creates List dynamic arrays 
        List<String> FrstName = new List<string>();
        List<String> LstName = new List<string>();
        List<String> Addrss1 = new List<string>();
        List<String> Addrss2 = new List<string>();
        List<String> Cty = new List<string>();
        List<String> Stte = new List<string>();
        List<String> ZpCd = new List<string>();
        List<String> Eml = new List<string>();
        List<String> HmPhn = new List<string>();
        List<String> ClPhn = new List<string>();
        List<String> WrkPhn = new List<string>();
        List<String> Brthdy = new List<string>();
        List<String> Nts = new List<string>();


        //Variable that holds the index for what contact we are looking
        int Index;

        public Form1()
            {
                InitializeComponent();
                //Used to set State Combo Box to "Please Choose One"
                CmboStte.SelectedIndex = 0;
                //Initializes the Index variable
                Index = 0;
            }

  

        //Functions for Add button
        private void AddCntctBtn_Click(object sender, EventArgs e)
        {//Add button START////  
               
                bool isValid = true;

                lblfdbck.Text = ""; //Label feed back string

                string CntctTxtRcrd;//String for gathering data


            //Validates if First name or Last name is filled in
            if (!VldtnLbry.IsItFlldN(txtFrstName.Text) & !VldtnLbry.IsItFlldN(txtLstName.Text))
            {
                    isValid = false;
                    lblfdbck.Text += "Error: Please enter a first or last name!\n";
            }


            //Validates if E-Mail is filled it
            if (VldtnLbry.IsItFlldN(txtEml.Text))
            {
                //Validates if E-Mail is valid format
                if (VldtnLbry.IsVldEml(txtEml.Text) == false)
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please enter a valid E-Mail address?\n";
                }
            }


            //Validate if Home phone number is filled in
            if (VldtnLbry.IsItFlldN(txtHmPhn.Text))
            {
                //Validates Home phone number length
                if (VldtnLbry.IsPhnNmbMnm(txtHmPhn.Text))
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please enter a valid 10 digit Home Phone Number\n";
                }
                //Validates if only digets are used in number
                if (VldtnLbry.IsAllDgts(txtHmPhn.Text) == false)
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please only enter numbers in Home Phone Number!\n";
                }
            }


            //Validates if Work phone number is filled in
            if (VldtnLbry.IsItFlldN(txtWrkPhn.Text))
            {
                //Validates Work phone number length
                if (VldtnLbry.IsPhnNmbMnm(txtWrkPhn.Text))
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please enter a valid 10 digit Work Phone Number\n";
                }
                //Validates if only digets are used in number
                if (VldtnLbry.IsAllDgts(txtWrkPhn.Text) == false)
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please only enter numbers in Work Phone Number!\n";
                }
            }


            //Validates if Cell phone number is filled in
            if (VldtnLbry.IsItFlldN(txtClPhn.Text))
             {
                //Validates Cell phone number length
                if (VldtnLbry.IsPhnNmbMnm(txtClPhn.Text))
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please enter a valid 10 digit Cell Phone Number\n";
                }
                //Validates if only digets are used in number
                if (VldtnLbry.IsAllDgts(txtClPhn.Text) == false)
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please only enter numbers in Cell Phone Number!\n";
                }
            }


            //Validates if Zip Code is filled in
            if (VldtnLbry.IsItFlldN(txtZpCd.Text))
            {
                //Validates Zip Code length
                if (VldtnLbry.IsZpMnm(txtZpCd.Text))
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please enter a valid 5 digit Zip Code\n";
                }
                //Validates if only digets are used in Zip Code
                if (VldtnLbry.IsAllDgts(txtZpCd.Text) == false)
                {
                    isValid = false;
                    lblfdbck.Text += "Error: Please only enter numbers in Zip Code!\n";
                }
            }

            //Stores Contact data
            CntctTxtRcrd = DateTime.Now.ToShortDateString() +
                           "," + txtFrstName.Text +
                           "," + txtLstName.Text +
                           "," + txtAddrss1.Text +
                           "," + txtAddrss2.Text +
                           "," + txtCty.Text +
                           "," + CmboStte.SelectedItem.ToString() +
                           "," + txtZpCd.Text +
                           "," + txtEml.Text +
                           "," + txtHmPhn.Text +
                           "," + txtClPhn.Text +
                           "," + txtWrkPhn.Text +
                           "," + BrthdPckr.Value +
                           "," + txtNts.Text;


            if (isValid)
            {   //Displays Birthday in MM/DD/YYYY format
                DateTime Brthday = new DateTime();
                Brthday = BrthdPckr.Value;


                //Display of First and Last name along with State in List Box
                CntctLstBx.Items.Add(txtFrstName.Text + " " +
                txtLstName.Text + " (" +
                CmboStte.SelectedItem.ToString() + ") " + Brthday.ToShortDateString());
                  

                //Displays verification in Feedback Label
                lblfdbck.Text = "Contact Added";
              }


            //Stores Contact data into text file
            FileIO.writeFile(@"Contacts.txt", CntctTxtRcrd, false);

        }//Add button END////




        //Functions for Clear button
        private void ClrFrmbtn_Click(object sender, EventArgs e)
        {
            //Used to clear text box and other fields
            txtFrstName.Clear();
            txtLstName.Clear();
            txtAddrss1.Clear();
            txtAddrss2.Clear();
            txtCty.Clear();
            txtZpCd.Clear();
            txtEml.Clear();
            txtHmPhn.Clear();
            txtClPhn.Clear();
            txtWrkPhn.Clear();
            lblfdbck.Text = " ";
            txtNts.Text = " ";
            CmboStte.SelectedIndex = 0;
            BrthdPckr.Value = DateTime.Now;
        }




        //Function for Clear List button
        private void ClrLstBtn_Click(object sender, EventArgs e)
        {
            //Clears List box
            CntctLstBx.Items.Clear();
        }

        private void mprtcntctlstbtn_Click(object sender, EventArgs e)
        {
            //Fills the List array with data
            FillLists(@"Contacts.txt", FrstName,LstName,Addrss1,Addrss2,Cty,Stte,ZpCd,Eml,HmPhn,ClPhn,WrkPhn,Brthdy,Nts);

            //Stores records into a string list varable
            List<string> cntcts = FileIO.readFile(@"Contacts.txt");

            foreach (string rcrd in cntcts)
            {
                string[] columns = rcrd.Split(',');

                string info = columns[1] + " " + columns[2] + ": " + columns[6];
                CntctLstBx.Items.Add(info);

                //    txtFrstName.Text = columns[1];
                //    txtLstName.Text = columns[2];
                //    txtAddrss1.Text = columns[3];
                //    txtAddrss2.Text = columns[4];
                //    txtCty.Text = columns[5];
                //    CmboStte.Text = columns[6];
                //    txtZpCd.Text = columns[7];
                //    txtEml.Text = columns[8];
                //    txtHmPhn.Text = columns[9];
                //    txtClPhn.Text = columns[10];
                //    txtWrkPhn.Text = columns[11];
                //    //BrthdPckr.Text = columns[12];
                //    txtNts.Text = columns[13];


            }

        }

        //Function that displays proper data
        public void FillMyForm(int Index)
        {
            txtFrstName.Text = FrstName[Index];
            txtLstName.Text = LstName[Index];
            txtAddrss1.Text = Addrss1[Index];
            txtAddrss2.Text = Addrss2[Index];
            txtCty.Text = Cty[Index];
            CmboStte.Text = Stte[Index];
            txtZpCd.Text = ZpCd[Index];
            txtEml.Text = Eml[Index];
            txtHmPhn.Text = HmPhn[Index];
            txtClPhn.Text = ClPhn[Index];
            txtWrkPhn.Text = WrkPhn[Index];
            //BrthdPckr.Value = Brthdy[Index];**BROKEN
            txtNts.Text = Nts[Index];
        }


        //Function that fills List Array
        public void FillLists (string FileName, List<string> Fname, List<string> Lname, List<string>Addrss1, List<string>Addrss2, List<string>Cty, List<string>Stte, List<string>ZpCd, List<string>Eml, List<string>HmPhn, List<string>CllPhn, List<string> WrkPhn,List<string>Brthdy,List<string>Nts)
        {
            //Clears existing Lists data
            FrstName.Clear();
            LstName.Clear();
            Addrss1.Clear();
            Addrss2.Clear();
            Cty.Clear();
            Stte.Clear();
            ZpCd.Clear();
            Eml.Clear();
            HmPhn.Clear();
            ClPhn.Clear();
            WrkPhn.Clear();
            Brthdy.Clear();
            Nts.Clear();

            StreamReader strmrdr;
            try
            {
                strmrdr = new StreamReader(File.Open
                (@FileName, FileMode.Open));

                try
                {
                    while (strmrdr.Peek() != -1)
                    {
                        string row = strmrdr.ReadLine();

                        string[] columns = row.Split(',');

                        FrstName.Add(columns[1]);
                        LstName.Add(columns[2]);
                        Addrss1.Add(columns[3]);
                        Addrss2.Add(columns[4]);
                        Cty.Add(columns[5]);
                        Stte.Add(columns[6]);
                        ZpCd.Add(columns[7]);
                        Eml.Add(columns[8]);
                        HmPhn.Add(columns[9]);
                        ClPhn.Add(columns[10]);
                        WrkPhn.Add(columns[11]);
                        Brthdy.Add(columns[12]);
                        Nts.Add(columns[13]);
                    }

                }
                finally { strmrdr.Close(); }
            }
            catch (Exception err)
            {//Catch statement to display any errors
                string errmsg = err.Message;
            }

            FillMyForm(Index);

        }

        //Function for Next contact button
        private void btnNxt_Click(object sender, EventArgs e)
        {
            Index++;
            if(Index >= FrstName.Count)
            {
                Index = FrstName.Count - 1;
            }
            FillMyForm(Index);
        }


        //Function for Last contact button
        private void btnPrvs_Click(object sender, EventArgs e)
        {
            Index--;

            if(Index < 0)
            {
                Index = 0;
            }
            FillMyForm(Index);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

            FrstName[Index] = txtFrstName.Text;
            LstName[Index] = txtLstName.Text;
            Addrss1[Index] = txtAddrss1.Text;
            Addrss2[Index] = txtAddrss2.Text;
            Cty[Index] = txtCty.Text;
            Stte[Index] = CmboStte.Text;
            ZpCd[Index] = txtZpCd.Text;
            Eml[Index] = txtEml.Text;
            HmPhn[Index] = txtHmPhn.Text;
            ClPhn[Index] = txtClPhn.Text;
            WrkPhn[Index] = txtWrkPhn.Text;
            //Brthdy[Index] = BrthdPckr.Value;**BROKEN
            Nts[Index] = txtNts.Text;

            lblfdbck.Text = FileIO.UpdateFile(@"Contacts.txt", FrstName, LstName, Addrss1, Addrss2, Cty, Stte, ZpCd, Eml, HmPhn, ClPhn, WrkPhn,Brthdy,Nts);
        }
    }
}
