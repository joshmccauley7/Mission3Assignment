using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Mission3Assignment
{
    internal class FoodItem
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public DateOnly Expiration { get; set; }

        public FoodItem(string name, string category, int quantity, DateOnly expiration) 
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            Expiration = expiration;
        }
        public void AddItem()
        {
            Console.Write("What is the name of the food? ");
            string foodName = Console.ReadLine();
            Console.Write("To what category does " + foodName + " belong? ");
            string category = Console.ReadLine();
            Console.Write("How many would you like to add to inventory? ");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("What is the expiration date? (MM/DD/YYYY) ");
            DateTime date = DateTime.Parse(Console.ReadLine());


            Console.WriteLine(foodName + category + quantity);

        }

        public void DeleteItem()
        {
            // fill in
        }

        public void Print()
        {
            Console.WriteLine($"{Name} | {Category} | Qty: {Quantity} | Expires: {Expiration}");
        }
    }
}
