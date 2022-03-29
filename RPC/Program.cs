using System;

namespace RPS
{
    enum RPS1
    {
        Камень = 1,
        Ножницы = 2,
        Бумага = 3
    }
    enum RPS2
    {
        Камень = 1,
        Ножницы = 2,
        Бумага = 3
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первый игрок, выбери свой ход");
            Console.WriteLine($"Камень {(int)RPS1.Камень}");
            Console.WriteLine($"Ножницы {(int)RPS1.Ножницы}");
            Console.WriteLine($"Бумага {(int)RPS1.Бумага}");
            string input1 = Console.ReadLine();
            RPS1 player1 = (RPS1)int.Parse(input1);
            Console.Clear();
            Console.WriteLine("Первый игрок, выбери свой ход");
            Console.WriteLine($"Камень {(int)RPS2.Камень}");
            Console.WriteLine($"Ножницы {(int)RPS2.Ножницы}");
            Console.WriteLine($"Бумага {(int)RPS2.Бумага}");
            string input2 = Console.ReadLine();
            RPS2 player2 = (RPS2)int.Parse(input2);
            Console.Clear();
            if ((int)player1 == (int)player2)
            {
                Console.WriteLine("НИЧЬЯ");
            }
            else
            {
                if (((int)player1==1 && (int)player2==2) || ((int)player1==2 && (int)player2==3) || ((int)player1==3 && (int)player2==1))
                {
                    Console.WriteLine("ПОБЕДИЛ ИГРОК 1");
                }
                else
                {
                    Console.WriteLine("ПОБЕДИЛ ИГРОК 2");
                }
            }
        }
    }
}