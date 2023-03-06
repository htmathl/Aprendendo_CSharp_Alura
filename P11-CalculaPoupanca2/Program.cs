using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Calcula Poupança");

        double investimento = 1000;

        /*
        while (mes <= 12)
        {
            investimento += investimento * 0.5 / 100;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
            mes++;
        }
        */

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento += investimento * 0.5 / 100;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }
    }
}