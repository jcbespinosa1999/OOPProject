using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    class Calculations
    {
        public static int CalculateAge(string birthDate, bool returnInMonths = false)
        {
            int age;

            DateTime now = DateTime.UtcNow;
            DateTime past = Convert.ToDateTime(birthDate);
            if (now.Month <= past.Month && now.Day <= past.Day)
            {
                age = (((now.Year - past.Year) + (now.Month - past.Month) / 12) - 1);
                if (age < 0)
                {
                    age = 0;
                }
            }
            else
            {
                age = (now.Year - past.Year) + (now.Month - past.Month) / 12;
                if (age < 0)
                {
                    age = 0;
                }
            }
            if (returnInMonths)
            {
                if (past.Month <= now.Month && past.Day <= now.Day)
                {
                    age = (((past.Year - now.Year) + (past.Month - now.Month) / 12) - 1);
                }
                else
                {
                    age = (past.Year - now.Year) + (past.Month - now.Month) / 12;
                }

                age = age * 12;
            }
            return age;
        }
        public static decimal CalculateInterest(decimal principalAmount, decimal monthlyRate)
        {
            return (principalAmount * (monthlyRate / 100));
        }
        public static decimal CalculateAccruedAmount(decimal principalAmount, decimal monthlyRate, string date)
        {
            return (principalAmount + (CalculateInterest(principalAmount, monthlyRate) * CalculateAge(date, true)));
        }
    }
}
