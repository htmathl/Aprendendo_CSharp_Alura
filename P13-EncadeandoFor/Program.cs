using System;
using System.Data.Common;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Encadeando for");

        //*
        //**
        //***
        //****
        //*****

        for(int linhas = 0; linhas < 10; linhas++)
        {
            for(int colunas = 0; colunas < 10; colunas++)
            {
                Console.Write("*");
                if (colunas >= linhas)
                    break;
            }
            Console.WriteLine();
        }

        //outro jeito de fazer
        for (int linhas = 0; linhas < 10; linhas++)
        {
            for (int colunas = 0; colunas <= linhas; colunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}