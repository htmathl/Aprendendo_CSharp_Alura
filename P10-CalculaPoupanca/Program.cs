using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Calcula Poupança");

        double investimento = 1000;

        //rendimento de 0.5% ao mês

        int mes = 1;

        while (mes <= 12) 
        {
            investimento += investimento * 0.5 / 100;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
            mes++;
        }
    }
}