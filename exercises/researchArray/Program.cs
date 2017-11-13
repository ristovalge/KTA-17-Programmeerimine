using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace researchArray
{
    class Program
    {
        static void Main(string[] args)
        {

               
                // googlr and try to understand what are arrays
                // greate small illustrative example
                // Do NOT copy & paste , use learn consepts tp vreate your own
                // Greaate pull request
                //Share with friends:



                // Specify the data source.
                string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

                foreach (string m in monthNames) // writing out
                {
                    Console.WriteLine(UppercaseFirst(m));



                string UppercaseFirst(string s)
                {
                    if (string.IsNullOrEmpty(s))
                    {
                        return string.Empty;
                    }
                    char[] a = s.ToCharArray();
                    a[0] = char.ToUpper(a[0]);
                    return new string(a);
                }
            }
            Console.ReadKey();

        }

    }
    
}
