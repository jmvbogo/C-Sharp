using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Contact_Manager_Form
{
    class FileIO
    {//FileIO Start////
        public static string writeFile(string Contacts, string myString, bool Overwrite)
        {//Write File Start////
            //Declare a StreamWriter
            StreamWriter strmwrtr;

            //String to show record writing progress
            string wrtngprgrs = "Record Added.";
            try
            {
                //If statement that allows deleting of file IF true
                if (Overwrite == true)
                {
                    File.Delete(@Contacts);
                }


                //Creates the StreamWriter and sets the filename and how it is opened
                strmwrtr =
                     new StreamWriter(File.Open(@Contacts,
                     FileMode.OpenOrCreate));

                //Declares the proper point to write data
                strmwrtr.BaseStream.Seek(0, SeekOrigin.End);

                //Writes data to proper point
                strmwrtr.WriteLine(myString);

                //Forces the write, saves the file, clears the buffer
                strmwrtr.Flush();

                //Closes the file whether or not there was an error
                strmwrtr.Close();
            }
            catch (Exception err)
            {
                string errmsg = err.Message;
                wrtngprgrs = "Error: " + errmsg;
            }
            finally
            {
            }

            return wrtngprgrs;
        }//Write File End////


        public static List<string> readFile (string Contacts)
        {//Start Read File////
            //String that will hold File Data for list box
            List<string> strngcntcts = new List<string>();

            //Declare a StreamReader
            StreamReader strmrdr;

            string rdngprgrs = "Record Uploaded.";
            try
            {//Creates Object and Declares Opening of File
                strmrdr = new StreamReader(File.Open
                (@Contacts, FileMode.Open));

                try
                {//Loops threw record till all records are read
                    while (strmrdr.Peek() != -1)
                    {
                        string row = strmrdr.ReadLine();

                        strngcntcts.Add(row);
                    }

                }
                finally { strmrdr.Close(); }
                
            }
            catch (Exception err)
            {//Catch statement to display any errors
                string errmsg = err.Message;
                rdngprgrs = "Error: " + errmsg;
            }
            return strngcntcts;
        }//End Read File////

        public static string UpdateFile(string FileName, List<string> Fname, List<string> Lname, List<string> Addrss1, List<string> Addrss2, List<string> Cty, List<string> Stte, List<string> ZpCd, List<string> Eml, List<string> HmPhn, List<string> CllPhn, List<string> WrkPhn, List<string> Brthdy, List<string> Nts)
        {
            int NmbrOfRcrds = Fname.Count - 1;
            int Index = 0;
            string strng = "";
            string strngfdbck = "";
            StreamWriter strmwrtr;

                try
                {
                    File.Delete(@FileName);

                    strngfdbck = "Contact Updated Successfully";

                    strmwrtr = new StreamWriter(File.Open(FileName, FileMode.OpenOrCreate));

                    for (int ctr = 0; ctr <= NmbrOfRcrds; ctr++)
                    {
                        strmwrtr.BaseStream.Seek(0, SeekOrigin.End);

                        strng = DateTime.Now.ToShortDateString() + "," + Fname[ctr] + "," + Lname[ctr] + "," + Addrss1[ctr] + "," + Addrss2[ctr] + "," + Cty[ctr] + "," + Stte[ctr] + "," + ZpCd[ctr] + "," + Eml[ctr] + "," + HmPhn[ctr] + "," + CllPhn[ctr] + "," + WrkPhn[ctr] + "," + Brthdy[ctr] + "," + Nts[ctr];

                        strmwrtr.WriteLine(strng);
                    }

                    strmwrtr.Flush();

                    strmwrtr.Close();
                }
                catch (Exception err)
                {
                    string errmsg = err.Message;
                    strngfdbck = "Error: " + errmsg;
                }
            return strngfdbck;
          }
        


    }//File IO End////
}