using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    class Product
    {
        public string Name;
        public string Description;
        public string Manufacturer;
        public int Items;
        public decimal Price;
        public decimal MonthlyInterestRate;
        public string DueDate;


        public void DeductItems(int items = 0)
        {
            if (items != 0)
            {
                Items = Items - items;
            }
            else
            {
                Items--;
            }
        }
    }
}
