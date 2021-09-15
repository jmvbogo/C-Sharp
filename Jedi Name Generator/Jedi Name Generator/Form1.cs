using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jedi_Name_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsbmt_Click(object sender, EventArgs e)
        {
            string result = "";
            string lst2frstnm = "";

            string plcbrn = txtplcbrn.Text;
            string mthrmdnnm = txtmthrmdnnm.Text;
            string frstnm = txtfrstnm.Text;
            string lstnm = txtlstnm.Text;


            int intfrst3ltrslstnm = lstnm.Length;
            int intlst2frstnm = frstnm.Length;
            int intfrst2mthrmdnnm = mthrmdnnm.Length;
            int intlst3plcbrn = plcbrn.Length;


            string frst3ltrslstnm = lstnm.Substring(0, 3);

            if (intlst2frstnm < 3) {lst2frstnm = frstnm;}
            else {lst2frstnm = frstnm.Substring(intlst2frstnm - 2);}
            

            
            string frst2mthrmdnnm = mthrmdnnm.Substring(0, 2);

            
            string lst3plcbrn = plcbrn.Substring(intlst3plcbrn - 3);

            result = frst3ltrslstnm + lst2frstnm + "-" + frst2mthrmdnnm + lst3plcbrn + "\nyour Jedi Name is.";

            lblfdbk.Text = result;
            
            
        }
    }
}
