using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.13;
        Console.WriteLine(salario);

        /*
         * mesmo não dando uma divisão exata para que o resultado seja
         * realmente double é necessário coloar algum dos números como
         * um double como no exemplo abaixo.
         */
        double idade = 7 / 5;
        Console.WriteLine(idade);

        idade = 7.0 / 5;
        Console.WriteLine(idade);
    }
}