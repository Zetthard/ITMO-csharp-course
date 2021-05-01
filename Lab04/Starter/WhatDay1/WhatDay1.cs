using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatDay1
{
    enum MonthName 
    { 
        January, 
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December 
    }
    class WhatDay
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of the day between 1 and 365: ");
            string line = Console.ReadLine();
            int daynum = int.Parse(line);
            int monthnum = 0;

            foreach (int daysInMonth in DaysInMonths)
                if (daynum <= daysInMonth)
                {
                    break;
                }
                else
                {
                    daynum -= daysInMonth;
                    monthnum++;
                }

            // end:
            
            MonthName temp = (MonthName)monthnum;
            string monthname = temp.ToString();

            //switch (monthnum)
            //{
            //    case 0:
            //        monthname = "january"; break;
            //    case 1:
            //        monthname = "february"; break;
            //    case 2:
            //        monthname = "march"; break;
            //    case 3:
            //        monthname = "april"; break;
            //    case 4:
            //        monthname = "may"; break;
            //    case 5:
            //        monthname = "june"; break;
            //    case 6:
            //        monthname = "july"; break;
            //    case 7:
            //        monthname = "august"; break;
            //    case 8:
            //        monthname = "september"; break;
            //    case 9:
            //        monthname = "october"; break;
            //    case 10:
            //        monthname = "november"; break;
            //    case 11:
            //        monthname = "december"; break;
            //    default:
            //        monthname = "not done yet"; break;
            //}

            Console.WriteLine("{0} {1}", daynum, monthname);
        }
         // Don't modify anything below here
        static System.Collections.ICollection DaysInMonths
        = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    }
       
}
