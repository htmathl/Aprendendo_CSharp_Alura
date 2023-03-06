using System;

class Programa
{
   static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Atribuições de variáveis");

        int idade = 30;
        int idadeAnna = idade;

        Console.WriteLine(idadeAnna);

        idade = 25;

        Console.WriteLine(idadeAnna);

        //instruções do código são lineares
    }
}