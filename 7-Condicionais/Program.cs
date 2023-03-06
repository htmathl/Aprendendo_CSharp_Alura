using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - condicionais");

        int idadeCleiton = 16;
        int qntPessoas = 0;

        if(idadeCleiton < 18 && qntPessoas == 0)
        {
            Console.WriteLine("Não pode entrar!");
            return;
        }

        Console.WriteLine("Entre!");

    }
}