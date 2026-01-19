using Mission3Assignment;

List<FoodItem> inventory = new List<FoodItem>();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Add Food Items");
    Console.WriteLine("2. Delete Food Items");
    Console.WriteLine("3. Print List of Current Food Items");
    Console.WriteLine("4. Exit the Program");

    Console.Write("What would you like to do? ");
    string answer = Console.ReadLine();

    if (answer == "1")
    {
        Console.WriteLine();
        Console.Write("Food name: ");
        string name = Console.ReadLine();

        // Category
        Console.Write("Category: ");
        string category = Console.ReadLine();

        // Quantity (no letters, no negatives)
        int quantity;
        while (true)
        {
            Console.Write("Quantity: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid non-negative number.");
            }
        }

        // Expiration date (must be real)
        DateOnly expiration;
        while (true)
        {
            Console.Write("Expiration date (MM/DD/YYYY): ");
            if (DateOnly.TryParse(Console.ReadLine(), out expiration))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid date in MM/DD/YYYY format.");
            }
        }

        // Create object using constructor
        FoodItem item = new FoodItem(name, category, quantity, expiration);
        inventory.Add(item);

        Console.WriteLine("Item added!");
    }

    else if (answer == "2")
    {
        Console.WriteLine();
        Console.Write("Enter the food name to delete: ");
        string deleteName = Console.ReadLine();

        FoodItem itemToRemove = inventory.Find(i => i.Name == deleteName);

        if (itemToRemove != null)
        {
            inventory.Remove(itemToRemove);
            Console.WriteLine("Item removed.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }
    else if (answer == "3")
    {
        Console.WriteLine();
        if (inventory.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
        }
        else
        {
            foreach (FoodItem item in inventory)
            {
                item.Print();
            }
        }
    }
    else if (answer == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Please choose a valid option");
        continue;
    }
}