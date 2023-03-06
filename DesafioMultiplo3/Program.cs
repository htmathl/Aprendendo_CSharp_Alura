using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio do múltiplo de 3");

        Console.WriteLine("Jeito Poggers:");
        for(int i = 3; i <= 100; i+=3)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        Console.WriteLine("Jeito Noggers:");
        for (int i = 1; i < 100; i++)
        {
            if(i % 3 == 0)
                Console.WriteLine(i);
        }
    }
}