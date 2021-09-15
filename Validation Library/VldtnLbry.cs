using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
{
    class VldtnLbry
    {

        //Function that receives string variable that validates field is full.
        public static bool IsItFlldN(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }
		
		//Function that receives string variable that validates field is full with a minimun length.
		 public static bool IsItFlldN(string temp int minLngth)
        {
            bool result = false;

            if (temp.Length > minLngth)
            {
                result = true;
            }

            return result;
        }
		
		//Function that receives string variable that validates field is full with a minimun length.
		 public static bool IsItFlldN(string temp int minLngth int maxLngth)
        {
            bool result = false;

            if (minLngth > maxLngth)
            {
                result = true;
            }

            return result;
        }

        //Function that validates a proper e-mail address.
        public static bool IsVldEml(string temp)
        {

            bool result = true;


            int AtLocation = temp.IndexOf("@");
            int NextAtLocation = temp.IndexOf("@", AtLocation + 1);

            int PeriodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                result = false;
            }

            else if (AtLocation < 2)
            {
                result = false;
            }

            else if (PeriodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;

        }

        public static bool IsPhnNmbMnm(string temp)
        {
            bool result = true;

            if (temp.Length == 10)
            {
                result = false;
            }

            return result;
        }

        public static bool IsZpMnm(string temp)
        {
            bool result = true;

            if (temp.Length == 5)
            {
                result = false;
            }

            return result;
        }


        public static bool IsAllDgts(string temp)
        {
            bool result = true;
            foreach (Char c in temp)
            {
                if (char.IsDigit(c) == false)
                {
                    result = false;
                }
            }
            return result;
        }







    } //
} //
