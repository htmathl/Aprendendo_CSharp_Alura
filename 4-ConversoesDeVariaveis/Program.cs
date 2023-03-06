using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine(salario);
        Console.WriteLine(salarioInteiro);

        //tipos de variáveis numéricas e quanto suportam
        short x = 15000;
        int y = 2000000000;
        long z = 2000000000000000;
        Console.WriteLine(x + y + z);

        //float suporta poucas casas decimais depois da virgula
        //double mais usado
        float altura = 1.62f;
        Console.WriteLine(altura);
        


    }
}