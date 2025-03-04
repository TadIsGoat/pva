List<string> products = new List<string>() { "iPhone X", "Macbook" };
int choice;

while (true)
{
    menu();
    switch (choice)
    {
        case 1:
            clearTheScreen("add");
            add();
            break;
        case 2:
            clearTheScreen("delete");
            delete();
            break;
        case 3:
            clearTheScreen("find");
            find();
            break;
        case 4:
            clearTheScreen("show");
            show();
            break;
        case 5:
            clearTheScreen("showAmount");
            showAmount();
            break;
        case 6:
            clearTheScreen("saveIntoFile");
            saveIntoFile();
            break;
        case 7:
            clearTheScreen("exit");
            Console.WriteLine("Exiting system support!");
            Environment.Exit(0);
            break;
    }
    Console.WriteLine("\nPress any key to continue!");
    Console.ReadKey();
}

void menu()
{
    Console.Clear();
    Console.WriteLine("===== System support =====");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Delete");
    Console.WriteLine("3. Find");
    Console.WriteLine("4. Show");
    Console.WriteLine("5. Show amount");
    Console.WriteLine("6. Save into file");
    Console.WriteLine("7. Exit");
    Console.WriteLine("-----------------");
    Console.Write("Your choice: ");
    choice = int.Parse(Console.ReadLine());
}

void add()
{
    Console.Write("Enter new product: ");
    string productToAdd = Console.ReadLine();
    products.Add(productToAdd);
    Console.WriteLine($"{productToAdd} added!");
}

void delete()
{
    Console.Write("Enter product to delete: ");
    string productToDelete = Console.ReadLine();
    if (products.Contains(productToDelete))
    {
        products.Remove(productToDelete);
        Console.WriteLine($"{productToDelete} deleted!");
    }
    else
    {
        Console.WriteLine("This product is not in the list!");
    }
}

void find()
{
    Console.Write("Enter product to find: ");
    string productToFind = Console.ReadLine();
    if (products.Contains(productToFind))
    {
        Console.WriteLine("This product is in the list!");
    }
    else
    {
        Console.WriteLine("This product is not in the list!");
    }
}

void show()
{
    foreach (string p in products)
    {
        Console.WriteLine(p);
    }
}

void showAmount()
{
    int counter = 0;
    Console.Write("Enter product to count: ");
    string productToCount = Console.ReadLine();
    for (int i = 0; i < products.Count; i++)
    {
        if(products[i] == productToCount)
        {
            counter++;
        }
    }
    Console.WriteLine($"The product {productToCount} is in the list {counter} times!");
}

void saveIntoFile()
{
    StreamWriter savedProducts = new StreamWriter(@"products.txt", true);
    foreach (string s in products)
    {
        savedProducts.WriteLine(s);
    }
    savedProducts.Close();
    Console.WriteLine("File saved!");
}

void clearTheScreen(string choiceString)
{
    Console.Clear();
    Console.WriteLine("===== System support =====");
    Console.WriteLine($"\nYour choice: {choiceString}");

}