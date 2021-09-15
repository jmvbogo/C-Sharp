using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Guitar_Form
{//START OF CUSTOM_GUITAR_FORM////
    public partial class Form1 : Form
    {//START OF FORM ONE////
        public Form1()
        {
            InitializeComponent();
            CmboStte.SelectedIndex = 1;
            CmboCty.SelectedIndex = 1;
        }

        private void PriceBuild_Click(object sender, EventArgs e)
        {//START OF GUITAR BUILD////
            int prtsprc = 0;
            string prtslst = "";
            string strngprtsprc = "";
            string strngfnldsply = "";

            //*******START OF BODY GROUP*******////
            //Statement for Strat Body Radio Button////
            if (stratbody.Checked)
            {
                prtsprc = prtsprc + 150;
                prtslst = prtslst + "Body: Strat Style,";
            }

            //Statement for Tele Body Radio Button////
            if (telebody.Checked)
            {
                prtsprc = prtsprc + 150;
                prtslst = prtslst + "Body: Tele Style,";
            }

            //Statement Les Paul Body Radio Button
            if (lpbody.Checked)
            {
                prtsprc = prtsprc + 200;
                prtslst = prtslst + "Body: Les Paul Style,";
            }

            //Statement for Flying V Body Radio Button
            if (flyvbody.Checked)
            {
                prtsprc = prtsprc + 125;
                prtslst = prtslst + "Body: Flying V Style,";
            }

            //Statement for Archtop Hollow Body Radio Button
            if (archbody.Checked)
            {
                prtsprc = prtsprc + 300;
                prtslst = prtslst + "Body: Archtop Hollow Body Style,";
            }


            //*******START OF NECK GROUP*******////
            //Statement for Modern Strat Neck Radio Button
            if (stratmdrnneck.Checked)
            {
                prtsprc = prtsprc + 150;
                prtslst = prtslst + "Neck: Modern Strat Style,";
            }

            //Statement for Vintage Strat Neck Radio Button
            if (stratvntgneck.Checked)
            {
                prtsprc = prtsprc + 200;
                prtslst = prtslst + "Neck: Vintage Strat Style,";
            }

            //Statement for Modern Tele Neck Radio Button
            if (telemdrnneck.Checked)
            {
                prtsprc = prtsprc + 150;
                prtslst = prtslst + "Neck: Modern Tele Style,";
            }

            //Statement for Vintage Tele Neck Radio Button
            if (televntgneck.Checked)
            {
                prtsprc = prtsprc + 200;
                prtslst = prtslst + "Neck: Vintage Tele Style,";
            }

            //Statement for Hombre Neck Radio Button
            if (hombreneck.Checked)
            {
                prtsprc = prtsprc + 175;
                prtslst = prtslst + "Neck: Hombre Style,";
            }

            //Statement for Slapshot Neck Radio Button
            if (slapshotneck.Checked)
            {
                prtsprc = prtsprc + 175;
                prtslst = prtslst + "Neck: Slapshot Style,";
            }


            //*******START OF PICKGUARD GROUP*******////
            //Statement for Strat Style Pickguard Radio Button
            if (startguard.Checked)
            {
                prtsprc = prtsprc + 25;
                prtslst = prtslst + "Pickguard: Strat Style,";
            }

            //Statement for Tele Style Pickguard Radio Button
            if (teleguard.Checked)
            {
                prtsprc = prtsprc + 25;
                prtslst = prtslst + "Pickguard: Tele Style,";
            }

            //Statement for Les Paul Pickguard Radio Button
            if (lpguard.Checked)
            {
                prtsprc = prtsprc + 25;
                prtslst = prtslst + "Pickguard: Les Paul Style,";
            }


            //*******START OF TUNERS GROUP*******////
            //Statement for Vintage Black Tuners Radio Button////
            if (vntgblktuner.Checked)
            {
                prtsprc = prtsprc + 30;
                prtslst = prtslst + "Tuners: Vintage Black Style,";
            }

            //Statement for Vintage Chrome Tuners Radio Button////
            if (vntgchrmtuner.Checked)
            {
                prtsprc = prtsprc + 35;
                prtslst = prtslst + "Tuners: Vintage Chrome Style,";
            }

            //Statement for Vintage Gold Tuners Radio Button////
            if (vntggldtuner.Checked)
            {
                prtsprc = prtsprc + 35;
                prtslst = prtslst + "Tuners: Vintage Gold Style,";
            }

            //Statement for Grover Delux Tuners Radio Button////
            if (grvrdlxtuner.Checked)
            {
                prtsprc = prtsprc + 40;
                prtslst = prtslst + "Tuners: Grover Delux,";
            }
            
            //Statement for Grover Locking Tuners Radio Button////
            if (grvrlcktuner.Checked)
            {
                prtsprc = prtsprc + 45;
                prtslst = prtslst + "Tuners: Grover Locking,";
            }

            //Statement for Tronical Self Tuners Radio Button////
            if (slftuner.Checked)
            {
                prtsprc = prtsprc + 220;
                prtslst = prtslst + "Tuners: Tronical Self Tuning System,";
            }


            //*******START OF PICKUPS GROUP*******////
            //Statement for Humbucker Pickups Radio Button////
            if (humbucker.Checked)
            {
                prtsprc = prtsprc + 125;
                prtslst = prtslst + "Pickups: Humbuckers X2,";
            }

            //Statement for Single Coil Pickups Radio Button////
            if (humbucker.Checked)
            {
                prtsprc = prtsprc + 130;
                prtslst = prtslst + "Pickups: Single Coil X3,";
            }

            //Statement for P-90 Pickups Radio Button////
            if (p90.Checked)
            {
                prtsprc = prtsprc + 130;
                prtslst = prtslst + "Pickups: P-90 X2,";
            }

            //Statement for Lip Stick Pickups Radio Button////
            if (lipstick.Checked)
            {
                prtsprc = prtsprc + 150;
                prtslst = prtslst + "Pickups: Lip Stick (SC X2 & H X1),";
            }


            //*******START OF BRIDGE GROUP*******////
            //Statement for Traditional Tremolo Radio Button////
            if (trdtnltremolo.Checked)
            {
                prtsprc = prtsprc + 70;
                prtslst = prtslst + "Bridge: Traditional Tremolo,";
            }

            //Statement for Schaller Non-Tremolo Radio Button////
            if (rollernontrem.Checked)
            {
                prtsprc = prtsprc + 60;
                prtslst = prtslst + "Bridge: Schaller Roller Non-Tremolo,";
            }

            //Statement Classic Locking Tremolo for Radio Button////
            if (lockingtremolo.Checked)
            {
                prtsprc = prtsprc + 130;
                prtslst = prtslst + "Bridge: Classic Locking Tremolo System,";
            }

            //Statement for Bigsby Vibrato Radio Button////
            if (bigsbyvibrato.Checked)
            {
                prtsprc = prtsprc + 160;
                prtslst = prtslst + "Bridge: Classic Bridge Vibrato,";
            }

            //Statement for Traditional Bridge Radio Button////
            if (trdtnltremolo.Checked)
            {
                prtsprc = prtsprc + 30;
                prtslst = prtslst + "Bridge: Traditional Bridge Piece,";
            }

            //Statement for Nashville Tune-O-Matic Radio Button////
            if (nashomatic.Checked)
            {
                prtsprc = prtsprc + 45;
                prtslst = prtslst + "Bridge: Nashville Tune-O-Matic,";
            }

            //Statement for Gotoh Hardtail Radio Button////
            if (gotohhardtail.Checked)
            {
                prtsprc = prtsprc + 45;
                prtslst = prtslst + "Bridge: Gotoh Hardtail,";
            }


            //*******START OF KNOBS GROUP*******////
            //Statement for Vintage Black Radio Button////
            if (knobvntgstrtblk.Checked)
            {
                prtsprc = prtsprc + 15;
                prtslst = prtslst + "Knobs: Vintage Black,";
            }

            //Statement for Vintage Cream Radio Button////
            if (knobvntgstrtcrm.Checked)
            {
                prtsprc = prtsprc + 15;
                prtslst = prtslst + "Knobs: Vintage Cream,";
            }

            //Statement for Vintage Gold Radio Button////
            if (knobvntgstrtgld.Checked)
            {
                prtsprc = prtsprc + 15;
                prtslst = prtslst + "Knob: Vintage Gold,";
            }

            //Statement for Bonnet Black Radio Button////
            if (knobbnntblk.Checked)
            {
                prtsprc = prtsprc + 10;
                prtslst = prtslst + "Knobs: Bonnet Black,";
            }

            //Statement for Bonnet Cream Radio Button////
            if (knobbnntcrm.Checked)
            {
                prtsprc = prtsprc + 10;
                prtslst = prtslst + "Knob: Bonnet Cream,";
            }

            //Statement for Bonnet Gold Radio Button////
            if (knobbnntgld.Checked)
            {
                prtsprc = prtsprc + 10;
                prtslst = prtslst + "Knob: Bonnet Gold,";
            }

            //Statement for Barrel Black Radio Button////
            if (knobbrrlblk.Checked)
            {
                prtsprc = prtsprc + 10;
                prtslst = prtslst + "Knob: Barrel Black,";
            }

            //Statement for Barrel Cream Radio Button////
            if (knobbrrlcrm.Checked)
            {
                prtsprc = prtsprc + 10;
                prtslst = prtslst + "Knob: Barrel Cream,";
            }

            //Statement for Barrel Gold Radio Button////
            if (knobbrrlgld.Checked)
            {
                prtsprc = prtsprc + 10;
                prtslst = prtslst + "Knob: Barrel Gold,";
            }


            //*******START OF STRAP BUTTONS GROUP*******////
            //Statement for Standered Black Strap Radio Button////
            if (stndrdstrpblk.Checked)
            {
                prtsprc = prtsprc + 20;
                prtslst = prtslst + "Strap: Standered Black,";
            }

            //Statement for Standered Crome Strap Radio Button////
            if (stndrdstrpcrm.Checked)
            {
                prtsprc = prtsprc + 20;
                prtslst = prtslst + "Strap: Standered Chrome,";
            }

            //Statement for Standered Strap Gold Radio Button////
            if (stndrdstrpgld.Checked)
            {
                prtsprc = prtsprc + 20;
                prtslst = prtslst + "Strap: Standered Gold,";
            }

            //Statement for Locking Black Strap Radio Button////
            if (lckngstrapblk.Checked)
            {
                prtsprc = prtsprc + 30;
                prtslst = prtslst + "Strap: Locking Black,";
            }

            //Statement for Locking Chrome Strap Radio Button////
            if (lckngstrapcrm.Checked)
            {
                prtsprc = prtsprc + 20;
                prtslst = prtslst + "Strap: Locking Chrome,";
            }

            //Statement for Locking Gold Strap Radio Button////
            if (lckngstrapgld.Checked)
            {
                prtsprc = prtsprc + 30;
                prtslst = prtslst + "Strap: Locking Gold,";
            }
            //*******START OF ACCESSORIES GROUP*******////
            //Statement for  Brown Leather Strap Accessory Radio Button////
            if (brwnlthrstrp.Checked)
            {
                prtsprc = prtsprc + 15;
                prtslst = prtslst + "Accessory: Brown Leather Strap,";
            }

            //Statement for Black Leather Strap Accessory Radio Button////
            if (blcklthrstrap.Checked)
            {
                prtsprc = prtsprc + 15;
                prtslst = prtslst + "Accessory: Black Leather Strap,";
            }

            //Statement for Clip Lock Strap Accessory Radio Button////
            if (cliplockstrp.Checked)
            {
                prtsprc = prtsprc + 25;
                prtslst = prtslst + "Accessory: DiMarzio Nylon ClipLock Strap,";
            }

            //Statement for Soft Travel Case Accessory Radio Button////
            if (softcase.Checked)
            {
                prtsprc = prtsprc + 85;
                prtslst = prtslst + "Accessory: Soft Travel Case,";
            }

            //Statement for Hardshell Travel Case Accessory Radio Button////
            if (hardcase.Checked)
            {
                prtsprc = prtsprc + 135;
                prtslst = prtslst + "Accessory: Hardshell Travel Case,";
            }

            //Statement for 12' Monster Audio Cable Accessory Radio Button////
            if (audiocable12.Checked)
            {
                prtsprc = prtsprc + 25;
                prtslst = prtslst + "Accessory: 12' Monster Audio Cable,";
            }



            {//Displays Total Price and Parts Chosen in ListBox////
                strngprtsprc = "Total Price: $" + prtsprc + ",";

                strngfnldsply = strngprtsprc + prtslst;

                string[] values = strngfnldsply.Split(',');

                foreach (string value in values)
                {
                    if (value.Trim() == "")
                        continue;
                    gtrbldfnldsply.Items.Add(value.Trim());
                }
            }

        }//END OF GUITAR BUILD////

        private void SendBuildBtn_Click(object sender, EventArgs e)
        {
            {
                lblfdbck.Text = "";

                bool isValid = true;

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
                        lblfdbck.Text += "Error: Please only enter numbers in Zip Code!\n";
                    }
                }


                //Display of First and Last name along with Address
                if (isValid)
                {   
                    shppngaddrssdsply.Items.Add(txtFrstName.Text + " " +
                    txtLstName.Text + " / " + txtAddrss1.Text + ", " + txtAddrss2.Text + ", "
                    + CmboCty.SelectedItem.ToString() + ", " + CmboStte.SelectedItem.ToString() + ", " + txtZpCd.Text);
                }
            }
        }
    }//END OF FORM ONE////
}//END OF CUSTOM_GUITAR_FORM////
