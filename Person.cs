using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    class Person
    {
        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public string BirthDate;
        public string Address;

        public string GetFullName()
        {
            return (CompleteLastName() + ", " + CompleteFirstName() + CompleteMiddleName());
        }
        public string CompleteFirstName()
        {
            string completeName = "";
            string substituteName = "";
            string[] ListOfNames = FirstName.Split(' ');

            for (int firstCount = 0; firstCount < ListOfNames.Length; firstCount++)
            {
                for (int secondCount = 1; secondCount < ListOfNames[firstCount].Length; secondCount++)
                {
                    substituteName = substituteName + (char.ToLower(ListOfNames[firstCount][secondCount]));
                }
                ListOfNames[firstCount] = (char.ToUpper((ListOfNames[firstCount][0]))) + substituteName + " ";
                completeName = completeName + ListOfNames[firstCount];
                substituteName = "";
            }

            return completeName;
        }
        public string CompleteLastName()
        {
            string completeName = "";
            string substituteName = "";
            string[] ListOfNames = LastName.Split(' ');

            for (int firstCount = 0; firstCount < ListOfNames.Length; firstCount++)
            {
                for (int secondCount = 1; secondCount < ListOfNames[firstCount].Length; secondCount++)
                {
                    substituteName = substituteName + (char.ToLower(ListOfNames[firstCount][secondCount]));
                }
                ListOfNames[firstCount] = (char.ToUpper((ListOfNames[firstCount][0]))) + substituteName + " ";
                completeName = completeName + ListOfNames[firstCount];
                substituteName = "";
            }

            return completeName;
        }
        public string CompleteMiddleName()
        {
            string completeName = "";
            if (MiddleInitial.Length == 1)
            {
                completeName = char.ToUpper(MiddleInitial[0]) + ".";
            }
            else
            {
                string substituteName = "";
                string[] ListOfNames = MiddleInitial.Split(' ');

                for (int firstCount = 0; firstCount < ListOfNames.Length; firstCount++)
                {
                    for (int secondCount = 1; secondCount < ListOfNames[firstCount].Length; secondCount++)
                    {
                        substituteName = substituteName + (char.ToLower(ListOfNames[firstCount][secondCount]));
                    }
                    ListOfNames[firstCount] = (char.ToUpper((ListOfNames[firstCount][0]))) + substituteName + " ";
                    completeName = completeName + ListOfNames[firstCount];
                    substituteName = "";
                }
            }

            return completeName;
        }
        public string GetBirthDate()
        {
            return BirthDate;
        }
        public string GetAddress()
        {
            return (char.ToUpper(Address[0]) + Address.Substring(1));
        }
        public static int GetAge(string birthDate)
        {
            return Calculations.CalculateAge(birthDate);
        }
    }
}
