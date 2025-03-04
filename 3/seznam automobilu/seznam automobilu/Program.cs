List<string> carsPraha = new List<string>() { "Polo", "Impreza", "Evolution VII", "Stratos", "Quatro", "MX-5" };
List<string> carsBrno = new List<string>() { "R-34 Skyline GTR", "RX-7 FD3S", "RX-7 FC", "E-36", "E-90", "Aventador STO" };
List<string> carsOstrava = new List<string>() { "180SX", "sileigthy", "AG-86 Levin", "AE-86 Panda Trueno", "911 GT3 RS" };
List<string> users = new List<string>() { "admin1", "user1" };
List<string> passwords = new List<string>() { "admin1password", "user1password" };

updateUserTXT();

Console.WriteLine(" ■");
Thread.Sleep(500);
Console.Clear();
Console.WriteLine(" ■ ■");
Thread.Sleep(500);
Console.Clear();
Console.WriteLine(" ■ ■ ■");
Thread.Sleep(500);
Console.Clear();

Main();
void Main()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("===== WELCOME =====");
        Console.WriteLine("\n1. Login");
        Console.WriteLine("2. Create a new account");
        Console.WriteLine("3. Exit");
        Console.WriteLine("\nYour choice: ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            login();
            captcha();
        }
        else if (choice == 2)
        {
            createAccount();
        }
        else if (choice == 3)
        {
            Console.Clear();
            Console.WriteLine("Exiting program!");
            Environment.Exit(0);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid choice, try again! (Press any key to continue)");
            Console.ReadKey();
            Main();
        }
        if (chooseAnEstablishment() == true)
        {
            chooseAnEstablishment();
        }
    }
}

void updateUserTXT()
{
    if (File.Exists(@"users.txt"))
    {
        StreamReader sr = new StreamReader(@"users.txt");
        string usersString = sr.ReadToEnd();
        sr.Close();

        StreamWriter usersTXT = new StreamWriter(@"users.txt", true);
        for (int i = 0; i < users.Count; i++)
        {
            if (!usersString.Contains($"U:{users[i]} = P:{passwords[i]};"))
            {
                usersTXT.WriteLine($"U:{users[i]} = P:{passwords[i]};");
            }
        }
        usersTXT.Close();
    }
    else
    {
        StreamWriter usersTXT = new StreamWriter(@"users.txt", true);
        for (int i = 0; i < users.Count; i++)
        {
            usersTXT.WriteLine($"U:{users[i]} = P:{passwords[i]};");
        }
        usersTXT.Close();
    }
}

void updateCarDatabaseTXT(string establishment, List<string> cars)
{
    //updatuje pouze pokud v listu přibyde item, ne když zmizí. Deletování itemů ve switchi v establishmentDetails()
    if (File.Exists($@"carDatabase{establishment}.txt"))
    {
        StreamReader sr = new StreamReader($@"carDatabase{establishment}.txt");
        string carDatabaseString = sr.ReadToEnd();
        sr.Close();

        StreamWriter carDatabaseTXT = new StreamWriter($@"carDatabase{establishment}.txt", true);
        for (int i = 0; i < cars.Count; i++)
        {
            if (!carDatabaseString.Contains($"{cars[i]}"))
            {
                carDatabaseTXT.WriteLine($"{cars[i]}");
            }
        }
        carDatabaseTXT.Close();
    }
    else
    {
        StreamWriter carDatabaseTXT = new StreamWriter($@"carDatabase{establishment}.txt", true);
        for (int i = 0; i < cars.Count; i++)
        {
            carDatabaseTXT.WriteLine($"{cars[i]}");
        }
        carDatabaseTXT.Close();
    }
}

void createAccount()
{
    Console.Clear();
    Console.WriteLine("===== NEW ACCOUNT =====");
    Console.Write("\nEnter your username: ");
    string newUsername = Console.ReadLine();
    string newPassword = ".";
    string confirmPassword = "";
    while (true)
    {
        Console.Write("\nEnter your password: ");
        newPassword = Console.ReadLine();
        Console.Write("Confirm your password: ");
        confirmPassword = Console.ReadLine();
        if (newPassword == confirmPassword)
        {
            users.Add(newUsername);
            passwords.Add(newPassword);
            updateUserTXT();

            Console.WriteLine("New account has been created! (Press any key to continue)");
            Console.ReadKey();
            Main();
        }
        if (newPassword != confirmPassword)
        {
            Console.WriteLine("Try again!");
        }
    }
}

void login()
{
    string userLogin;
    string userPassword;
    int passwordTries = 0;

    StreamReader x = new StreamReader(@"users.txt");
    string usersString = x.ReadToEnd();
    x.Close();

    while (true)
    {
        Console.Clear();
        Console.WriteLine("===== LOGIN =====");
        Console.Write("\nLogin: ");
        userLogin = Console.ReadLine();
        if (usersString.Contains($"U:{userLogin}"))
        {
            break;
        }
    }

    while (passwordTries < 3)
    {
        passwordTries++;
        Console.Write("\nPassword: ");
        userPassword = Console.ReadLine();
        if (usersString.Contains($"P:{userPassword}"))
        {
            break;
        }
    }
    if (passwordTries > 3)
    {
        Console.WriteLine("Login failed, try again! (Press any key to continue)");
        Console.ReadKey();
        Main();
    }
}

void captcha()
{

    int captchaTries = 0;

    while (captchaTries < 3)
    {
        Random generator = new Random();
        int random = generator.Next(10000, 99999);
        string randomString = random.ToString();
        string[] captchaCode = randomString.Split();

        Console.Clear();
        Console.WriteLine("===== CAPTCHA =====");
        captchaTries++;
        Console.Write($"\nGenerated CAPTCHA code: ");
        for (int i = 0; i < 5; i++)
        {
            Random generator2 = new Random();
            int random2 = generator2.Next(1, 6);
            switch (random2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.Write($"{randomString[i]}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.Write("\nEnter the CAPTCHA code: ");
        string userCaptcha = (Console.ReadLine());
        if (userCaptcha == randomString)
        {
            Console.WriteLine("Login succesful! (Press any key to continue)");
            Console.ReadKey();
            break;
        }
    }
    if (captchaTries > 3)
    {
        Console.WriteLine("Login failed, try again! (Press any key to continue)");
        Console.ReadKey();
        Main();
    }
}

bool chooseAnEstablishment()
{
    Console.Clear();
    Console.WriteLine("===== CHOOSE AN ESTABLISHMENT =====");
    Console.Write("\nChoose an establishment (Praha/Brno/Ostrava): ");
    string establishmentChoice = Console.ReadLine();
    switch (establishmentChoice.ToLower())
    {
        case "praha":
            while (establishmentDetails(establishmentChoice.ToLower(), carsPraha) == true)
            {
                establishmentDetails(establishmentChoice.ToLower(), carsPraha);
            }
            return false;
        case "brno":
            while (establishmentDetails(establishmentChoice.ToLower(), carsBrno) == true)
            {
                establishmentDetails(establishmentChoice.ToLower(), carsBrno);
            }
            return false;
        case "ostrava":
            while (establishmentDetails(establishmentChoice.ToLower(), carsOstrava) == true)
            {
                establishmentDetails(establishmentChoice.ToLower(), carsOstrava);
            }
            return false;
        default:
            Console.Clear();
            Console.WriteLine("Invalid choice, try again! (Press any key to continue)");
            Console.ReadKey();
            return true;
    }
}

bool establishmentDetails(string establishment, List<string> cars)
{
    updateCarDatabaseTXT(establishment, cars);

    Console.Clear();
    Console.WriteLine($"===== CAR DATABASE - {establishment.ToUpper()} =====");
    Console.WriteLine("\n1. Add a car");
    Console.WriteLine("2. Delete one");
    Console.WriteLine("3. Delete all");
    Console.WriteLine("4. Find");
    Console.WriteLine("5. List");
    //autosave
    Console.WriteLine("6. Logout");
    Console.WriteLine("\nYour choice: ");
    int action = int.Parse(Console.ReadLine());
    Console.Clear();
    switch (action)
    {
        case 1:
            Console.WriteLine("Your choice: Add");
            Console.Write("\nEnter new product: ");
            string carToAdd = Console.ReadLine();
            cars.Add(carToAdd);
            Console.WriteLine($"{carToAdd} added! (Press any key to continue)");
            Console.ReadKey();
            return true;
        case 2:
            //deletuje pouze z listu, ale ne ze souboru. Pro deletování ze souboru je potřeba upravit funkci UpdateCarDatabase aby načítala itemy ze souboru do listu už od začátku programu.
            Console.WriteLine("Your choice: Delete one");
            Console.Write("\nEnter a car to delete: ");
            string carToDelete = Console.ReadLine();
            if (cars.Contains(carToDelete))
            {
                cars.Remove(carToDelete);
                Console.WriteLine($"{carToDelete} deleted! (Press any key to continue)");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This car is not in the list! (Press any key to continue)");
                Console.ReadKey();
            }
            return true;
        case 3:
            bool checkmark = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Your choice: Delete all");
                Console.Write("\nAre you sure you want to delete all? (y/n): ");
                char yn = char.Parse(Console.ReadLine());
                if (yn == 'y')
                {
                    StreamWriter sw = new StreamWriter($@"carDatabase{establishment}.txt", false);
                    sw.Write(string.Empty);
                    sw.Close();
                    cars.Clear();
                    Console.WriteLine("All cars have been deleted! (Press any key to continue)");
                    Console.ReadKey();
                    checkmark = true;
                }
                else if (yn == 'n')
                {
                    Console.WriteLine("Returning to menu! (Press any key to continue)");
                    Console.ReadKey();
                    Console.Clear();
                    checkmark = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again! (Press any key to continue)");
                    Console.ReadKey();
                }
            } while (checkmark == false);
            return true;
        case 4:
            Console.WriteLine("Your choice: Find");
            Console.Write("\nEnter product to find: ");
            int counter = 0;
            string productToFind = Console.ReadLine();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].ToLower() == productToFind.ToLower())
                {
                    counter++;
                }
            }
            Console.WriteLine($"The model {productToFind} is in the list {counter} times. (Press any key to continue)");
            Console.ReadKey();
            return true;
        case 5:
            Console.WriteLine("Your choice: List");
            Console.WriteLine($"\nThe cars in {establishment.ToUpper()}: ");
            StreamReader sr = new StreamReader($@"carDatabase{establishment}.txt");
            string output = sr.ReadToEnd();
            Console.Write(output);
            sr.Close();
            Console.WriteLine("(Press any key to continue)");
            Console.ReadKey();
            return true;
        case 6:
            checkmark = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Your choice: Logout");
                Console.Write("\nAre you sure you want to logout? (y/n): ");
                char yn = char.Parse(Console.ReadLine());
                if (yn == 'y')
                {
                    Console.WriteLine("You have been succestully loged out! (Press any key to continue)");
                    Console.ReadKey();
                    Main();
                    checkmark = true;
                }
                else if (yn == 'n')
                {
                    Console.WriteLine("Returning to menu! (Press any key to continue)");
                    Console.ReadKey();
                    Console.Clear();
                    checkmark = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again! (Press any key to continue)");
                    Console.ReadKey();
                }
            } while (checkmark == false);
            return true;
        default:
            Console.WriteLine("Invalid choice, try again! (Press any key to continue)");
            Console.ReadKey();
            return true;
    }
}








/* DELETE USERTXT
    StreamWriter sw = new StreamWriter(@"users.txt", false);
    sw.Write(string.Empty);
    sw.Close();
*/