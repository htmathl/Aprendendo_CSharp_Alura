using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio fatorial");

        int fatorial = 1;

        while(fatorial <= 10)
        {
            int resultado = 1;
            for (int n = 1; n <= fatorial; n++)
            {
                resultado *= n;
            }
            Console.WriteLine(resultado);
            fatorial++;
        }

        int fatoriall = 1;
        for (int il = 1; il < 11; il++)
        {
            fatoriall *= il;
            Console.WriteLine("Fatorial de " + il + " = " + fatoriall);
        }
    }
}