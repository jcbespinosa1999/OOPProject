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

        public Person(string firstName, string lastName, string middleInitial ="")
        {
            FirstName = FormatName(firstName);
            LastName = FormatName(lastName);
            MiddleInitial = FormatName(middleInitial);
        }
        public string GetFullName()
        {
            return String.Format("{0} {1}. {2}", FirstName, MiddleInitial[0], LastName);
        }
        private string FormatName(string name)
        {
            name = name.ToLower();
            string[] names = name.Split(' ');
            string formattedName = " ";
            for (int counter = 0; counter < names.Length; counter++)
                formattedName = formattedName + char.ToUpper(names[counter][0]) + names[counter].Substring(1) + " ";
            return formattedName.Remove(formattedName.Length - 1);
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