using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Customer = new Person();

            Product PersonPurchasing = new Product();
            Product Jewelry = new Product();

            Console.Write("First Name: ");
            Customer.FirstName = Console.ReadLine();
            Console.Write("Middle Initial: ");
            Customer.MiddleInitial = Console.ReadLine();
            Console.Write("Last Name: ");
            Customer.LastName = Console.ReadLine();
            Console.Write("Birthdate(dd/mm/yyyy): ");
            Customer.BirthDate = Console.ReadLine();
            Console.Write("Address: ");
            Customer.Address = Console.ReadLine();
            do
            {
                Console.Write("Jewelry: ");
                PersonPurchasing.Name = Console.ReadLine();
                string substituteNaming = "";
                for (int counter = 1; counter < (PersonPurchasing.Name).Length; counter++)
                {
                    substituteNaming = substituteNaming + (char.ToLower(PersonPurchasing.Name[counter]));
                }
                PersonPurchasing.Name = (char.ToUpper(PersonPurchasing.Name[0]) + substituteNaming);
                switch (PersonPurchasing.Name)
                {
                    case ("Necklace"):
                        {
                            Jewelry.Name = "Necklace";
                            Jewelry.Price = 5000;
                            Jewelry.Items = 3;
                            Jewelry.MonthlyInterestRate = 1.3M;
                            break;
                        }

                    case "Earrings":
                        {
                            Jewelry.Name = "Earrings";
                            Jewelry.Price = 1500;
                            Jewelry.Items = 5;
                            Jewelry.MonthlyInterestRate = 0.5M;
                            break;
                        }

                    case "Rings":
                        {
                            Jewelry.Name = "Rings";
                            Jewelry.Price = 2000;
                            Jewelry.Items = 8;
                            Jewelry.MonthlyInterestRate = 0.7M;
                            break;
                        }

                    case "Bracelets":
                        {
                            Jewelry.Name = "Bracelets";
                            Jewelry.Price = 3000;
                            Jewelry.Items = 4;
                            Jewelry.MonthlyInterestRate = 1M;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("We don't have " + PersonPurchasing.Name);
                            Jewelry.Name = "";
                            break;
                        }
                }
            } while (PersonPurchasing.Name != Jewelry.Name);

            do
            {
                Console.Write("Number of Items: ");
                PersonPurchasing.Items = Convert.ToInt32(Console.ReadLine());
                if (PersonPurchasing.Items > Jewelry.Items)
                {
                    Console.WriteLine("We only have " + Jewelry.Items + " in this Jewelry.");
                }
            } while (PersonPurchasing.Items > Jewelry.Items);

            do
            {
                Console.Write("Due Date(dd/mm/yyyy): ");
                PersonPurchasing.DueDate = Console.ReadLine();
                if ((Convert.ToDateTime(PersonPurchasing.DueDate)) < DateTime.UtcNow)
                {
                    Console.WriteLine("Invalid Date.");
                }
            } while ((Convert.ToDateTime(PersonPurchasing.DueDate)) < DateTime.UtcNow);
            //Console.Clear();
            Console.WriteLine("--------------------------");

            Console.WriteLine("Customer: " + Customer.GetFullName());
            Console.WriteLine("Birthdate: " + Customer.GetBirthDate());
            Console.WriteLine("Age: " + Person.GetAge(Customer.BirthDate));
            Console.WriteLine("Address: " + Customer.GetAddress());
            Console.WriteLine("Number of items purchased: " + PersonPurchasing.Items);
            Console.WriteLine("Name of Jewelry: " + PersonPurchasing.Name);
            Console.WriteLine("Total Price of " + PersonPurchasing.Name + ": " + (Jewelry.Price * PersonPurchasing.Items));
            Console.WriteLine("Interest per Month: " + Calculations.CalculateInterest((Jewelry.Price * PersonPurchasing.Items), Jewelry.MonthlyInterestRate));
            Console.WriteLine("Accrued Amount on Due Date: " + Calculations.CalculateAccruedAmount((Jewelry.Price * PersonPurchasing.Items), Jewelry.MonthlyInterestRate, PersonPurchasing.DueDate));
            Console.WriteLine("Number of items left in " + PersonPurchasing.Name + " is: " + (Jewelry.Items - PersonPurchasing.Items));
            Console.ReadLine();
        }
    }
}
