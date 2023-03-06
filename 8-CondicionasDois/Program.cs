using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - condicionais 2");

        int idadeCleiton = 17;
        int qntPessoas = 1;

        bool acompanhado = qntPessoas >= 1;
        string miau = !acompanhado ? "não " : "";

        Console.WriteLine(miau + "está acompanhado!");

        //mudando operador para que esteja acompanhado e seja maior
        if (idadeCleiton < 18 || qntPessoas == 0)
        {
            Console.WriteLine("Não pode entrar!");
            return;
        }

        Console.WriteLine("Entre!");

    }
}