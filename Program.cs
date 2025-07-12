using System;

class Programa
{
    static void Main()
    {
        Console.Clear();
         Cadastro cad = new Cadastro();
         Console.WriteLine("=========================== GERAR PLANILHA 1.0V=================================");
         Console.WriteLine("\n1. Entrar no usuario.");
         Console.WriteLine("2. Cadastrar.");
         Console.WriteLine("3. Sair.");
         Console.WriteLine();
         string opcao = Console.ReadLine();
         if (opcao == "3")
         {
            Fechar.Exit(opcao);
         }
         else if (opcao == "2")
         {
            cad.Autenticacao();
         }
         else
         {
            Console.WriteLine("opcao invalida");
         }
    }
}