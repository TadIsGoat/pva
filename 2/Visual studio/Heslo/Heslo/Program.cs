Console.WriteLine("Přihlaste se!");

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine("Zadejte heslo: ");
    string heslo = Console.ReadLine();

    if(heslo =="12345")
    {
        Console.WriteLine("Vítejte v systému");
        Console.WriteLine("Potřebovali jste {0} pokusů", i);
        i = 4;
    }
    else
    {
        Console.WriteLine("Tohle je špatné heslo!");
        if (i >= 3 )
        {
            Console.WriteLine("Spotřebovali jste všechny {0} pokusy!", i);
        }
    }

}

Console.WriteLine("Program se ukončuje");
