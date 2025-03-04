//proměnné
using System.Drawing;
using System.Text;
using System.Xml;

int[,] plocha = new int[9, 9]; //určení velikosti plochy; [19, 19] pro plnohodnotné sudoku
int[,] reseni = new int[4,4];
//výpis zadání - pouze jedna možnost zadání pro zjednodušení programu (zbytek hodnot doplní uživatel)
reseni[0,0] = 1;
reseni[0,2] = 2;
reseni[1,1] = 2;
reseni[1,3] = 4;
reseni[2,0] = 4;
reseni[2,3] = 3;
reseni[3,0] = 3;
reseni[3,3] = 1;

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(reseni[i,j]);
    }
    Console.WriteLine(  );
}

Console.WriteLine("x\xB2");
Console.WriteLine("x²");
Console.WriteLine("x{\u00B2}");
Console.WriteLine("x\xB2");
Console.WriteLine("x\u2072");
Console.WriteLine("x\u00b9");

VypisPlochy();
void VypisPlochy()
{
    int counter = 0; //counter obsluhující číslování řádků
    int counter2 = 0; //counter obsluhující výpis řešení
    
    //číslování sloupců
    Console.Write("  ");
    for (int a = 1; a <= 4; a++) //je potřeba změnit limit a<=x při změně velikosti pole
    {
        Console.Write("  {0} ", a);
    }
    Console.WriteLine();

    for (int i = 0; i < plocha.GetLength(0); i++)
    {
        //číslování řádků
        if ((i + 1) % 2 == 0)
        {
            counter++;
            Console.Write("{0} ", counter);
        }
        else //mezery pro prázdná místa v poli
        {
            Console.Write("  ");
        }

        //rámeček
        for (int j = 0; j < plocha.GetLength(1); j++)
        {
            //top
            if (i == 0 && j == 0)
            {
                Console.Write("╔"); //top left
            }
            else if (i == 0 && j == (plocha.GetLength(0) - 1))
            {
                Console.Write("╗"); //top right
            }
            else if (i == 0 && (j + 1) % 2 == 0)
            {
                Console.Write("═══"); //top line
            }
            else if (i == 0 && (j + 1) % 2 == 1)
            {
                Console.Write("╦"); //top crossing
            }

            //left
            else if (j == 0 && i == (plocha.GetLength(0) - 1))
            {
                Console.Write("╚"); //left bot
            }
            else if (j == 0 && (i + 1) % 2 == 0)
            {
                Console.Write("║"); //left line
            }
            else if (j == 0 && (i + 1) % 2 == 1)
            {
                Console.Write("╠"); //left crossing
            }

            //bot
            else if (i == (plocha.GetLength(0) - 1) && j == (plocha.GetLength(1) - 1))
            {
                Console.Write("╝"); //bot right
            }
            else if (i == (plocha.GetLength(0) - 1) && (j + 1) % 2 == 0)
            {
                Console.Write("═══"); //bot line
            }
            else if (i == (plocha.GetLength(0) - 1) && (j + 1) % 2 == 1)
            {
                Console.Write("╩"); //bot crossing
            }

            //right
            /*else if (j == 0 && i == (plocha.GetLength(0) - 1))
            {
                Console.Write("╝"); //bot right
            }*/
            else if (j == (plocha.GetLength(0) - 1) && (i + 1) % 2 == 0)
            {
                Console.Write("║"); //right line
            }
            else if (j == (plocha.GetLength(0) - 1) && (i + 1) % 2 == 1)
            {
                Console.Write("╣"); //right crossing
            }
            
            //fill
            else if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
            {
                //Console.Write("   "); //empty number spots - delete later
                Console.Write($" {reseni[counter2,counter2]} "); //number spots
                counter2++;
            }
            else if ((i + 1) % 2 == 1 && (j + 1) % 2 == 1)
            {
                Console.Write("╬"); //inside crossings
            }
            else if ((i + 1) % 2 == 0 && (j + 1) % 2 == 1)
            {
                Console.Write("║"); //inside lines vertical
            }
            else if ((i + 1) % 2 == 1 && (j + 1) % 2 == 0)
            {
                Console.Write("═══"); //inside lines horizontal
            }
            else //vypíše nuly pokud ve výpisu rámečku něco chybí 
            {
                Console.Write(plocha[i, j]);
            }
        }
        Console.WriteLine();
    }
}


/*
179 │
180 ┤
185 ╣
186 ║
187 ╗
188 ╝
191 ┐
192 └
193 ┴
194 ┬
195 ├
196 ─
197 ┼
200 ╚
201 ╔
202 ╩
203 ╦
204 ╠
205 ═
206 ╬
210 ╔
217 ┘
218 ┌


╔══╦══╗
║  ║  ║
╠══╬══╣
║  ║  ║
╚══╩══╝
*/