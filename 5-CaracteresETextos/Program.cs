using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e texto");

        char letra = 'a';
        Console.WriteLine(letra);

        //chars também tem códigos representados por números
        //necessária conversão
        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)98;
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        //strings podem ser vazias, enquanto chars não
        string vazia = "";
        // char vazio = ""; // ERRO
        char espaco = ' '; // pode ter espaço, necessário aspas simples

        Console.WriteLine(vazia);
        Console.WriteLine(espaco);

        //como pular de linha
        string cursos = @"cursos disponíveis: 
-Go 
-C# 
-Python 
-Java";
        Console.WriteLine(cursos);
    }
}