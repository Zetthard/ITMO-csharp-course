using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatDay1
{
    class WhatDay
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of the day between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            int monthNum = 0;

            if (daynum <= 31)
            { // january
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }

            if (daynum <= 28)
            { // february
                goto end;
            }
            else
            {
                daynum -= 28;
                monthnum++;
            }

            if (daynum <= 31)
            { // march
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }

            if (daynum <= 30)
            { // april
                goto end;
            }
            else
            {
                daynum -= 30;
                monthnum++;
            }

            if (daynum <= 31)
            { // may
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }


            if (daynum <= 30)
            { // june
                goto end;
            }
            else
            {
                daynum -= 30;
                monthnum++;
            }

            if (daynum <= 31)
            { // july
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }

            if (daynum <= 31)
            { // august
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }

            if (daynum <= 30)
            { // september
                goto end;
            }
            else
            {
                daynum -= 30;
                monthnum++;
            }

            if (daynum <= 31)
            { // october
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }

            if (daynum <= 30)
            { // november
                goto end;
            }
            else
            {
                daynum -= 30;
                monthnum++;
            }

            if (daynum <= 31)
            { // december
                goto end;
            }
            else
            {
                daynum -= 31;
                monthnum++;
            }

            End;

            string monthName;

            switch (monthnum)
            {
                case 0:
                    monthname = "january"; break;
                case 1:
                    monthname = "february"; break;
                case 2:
                    monthname = "march"; break;
                case 3:
                    monthname = "april"; break;
                case 4:
                    monthname = "may"; break;
                case 5:
                    monthname = "june"; break;
                case 6:
                    monthname = "july"; break;
                case 7:
                    monthname = "august"; break;
                case 8:
                    monthname = "september"; break;
                case 9:
                    monthname = "october"; break;
                case 10:
                    monthname = "november"; break;
                case 11:
                    monthname = "december"; break;
                default:
                    monthname = "not done yet"; break;
            }

            Console.WriteLine("Day: {0}, Month: {1}", dayNum, monthName);
        }
            // Don't modify anything below here
             static System.Collections.ICollection DaysInMonths
             = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
    }
}
