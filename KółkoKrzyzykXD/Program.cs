using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KółkoKrzyzykXD
{
    class Program
    {
        static void Main(string[] args)
        {
            string imieGraczaA = "";
            string imieGraczab = "";
            char znakGraczaA = "X";
            char znakGraczaB = "O";
                char[,] plansza = new char[3, 3]
                {
                    { '1', '2', '3' },
                    { '4', '5', '6' },
                    { '7', '8', '9' }
                };
            Console.Write("Wpisz imie graczaA: ");
            imieGraczaA = Console.ReadLine();
            Console.Write("Wpisz imie graczaB: ");
            imieGraczab = Console.ReadLine();
            //...
        }
    }
}
