using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 4000;

        if(salario <= 2800.0)
            salario -= salario * (75.0/10);

        if (salario <= 3751.0 && salario > 2800)
            salario -= salario * (15.0/100);

        if (salario > 3751)
            salario -= salario * (22.5/100);

        Console.WriteLine(salario);
    }
}