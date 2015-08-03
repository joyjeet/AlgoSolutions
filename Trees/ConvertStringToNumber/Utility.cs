using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumber
{
    public class Utility
    {

        /// <summary>
        /// This is a simple version where assumption is
        /// 1. input is always position integer as string
        /// 2. no alphabets or punctuations. 
        /// 
        /// Fail cases:
        /// 1. if the number is too large, outside of -2^31+1 to  2^31-1
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static long StringToLong(string s)
        {
            long returnVal = 0;

            if (!string.IsNullOrEmpty(s.Trim()))
            {
                char[] strArray = s.ToCharArray();

                for (int i = 0; i < strArray.Length; i++)
                {
                    if (strArray[i] >= 48 && strArray[i] <= 57)
                    {
                        returnVal = (returnVal * 10) + (strArray[i] - 48);
                    }
                    else
                    {
                        returnVal = -1; //not a valid number
                        break;
                    }
                }
            }
            return returnVal;
        }

        /// <summary>
        /// This is advance version of the above. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static long StringToLongAdvance(string s)
        {
            long returnVal = 0;
            long negetiveInput = 1;

            if (!string.IsNullOrEmpty(s.Trim()))
            {
                char[] strArray = s.ToCharArray();

                for (int i = 0; i < strArray.Length; i++)
                {
                    // only if first character is negetive
                    if (i==0 && strArray[0] == 45)
                    {
                        negetiveInput = -1;
                        i++;
                    }


                    if (strArray[i] >= 48 && strArray[i] <= 57)
                    {
                        returnVal = (returnVal * 10) + (strArray[i] - 48);
                    }
                    //consider space is ok but non numeric character is not ok
                    else if(strArray[i] != 32 && (strArray[i] <= 43 || strArray[i] >= 46))
                    {
                        returnVal = 0; // has non numeric character
                        break;
                    }
                }
            }
            return returnVal * negetiveInput;
        }
    }
}
