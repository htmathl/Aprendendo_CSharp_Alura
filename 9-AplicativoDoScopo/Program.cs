using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - condicionais 2");

        int idadeCleiton = 18;
        int qntPessoas = 0;

        bool acompanhado = qntPessoas >= 1;
        string strAcompanhado = !acompanhado ? "Não está acompanhado" : "Está acompanhado";

        if (idadeCleiton < 18 || qntPessoas == 0)
        {
            Console.WriteLine("Não pode entrar!");
            Console.WriteLine(strAcompanhado);
            return;
        }

        Console.WriteLine("Entre!");
        Console.WriteLine(strAcompanhado);

    }
}