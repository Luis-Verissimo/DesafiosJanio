using System.IO;
using System.Threading;
using System;

namespace desafio1;

class Program
{
    public static void Main()
    {
        Menu(); 
    }

    public static void Menu()
    {
        Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

███╗░░██╗░█████╗░███╗░░░███╗███████╗░██████╗
████╗░██║██╔══██╗████╗░████║██╔════╝██╔════╝
██╔██╗██║██║░░██║██╔████╔██║█████╗░░╚█████╗░
██║╚████║██║░░██║██║╚██╔╝██║██╔══╝░░░╚═══██╗
██║░╚███║╚█████╔╝██║░╚═╝░██║███████╗██████╔╝
╚═╝░░╚══╝░╚════╝░╚═╝░░░░░╚═╝╚══════╝╚═════╝░");
        Console.WriteLine("");
        Console.WriteLine("1) - Inserir primeiro nome");
        Console.WriteLine("2) - Inserir sobrenome");
        Console.WriteLine("3) - Deletar Nome/Sobrenome");
        Console.WriteLine("4) - Gerar nome completo aleatório");
        Console.WriteLine("5) - Listar nomes");
        Console.WriteLine("6) - Sair\n");
        string op = Console.ReadLine();
        
        switch (op) //Tratamento da escolha feita no menu
        {
            case "1": 
                { 
                    Console.Clear();
                    Metodos.InserirNome(); 
                    break;
                }
            case "2":
                {
                    Console.Clear();
                    Metodos.InserirSobrenome();
                    break;
                }
            case "3":
                {
                    Console.Clear();
                    Metodos.DeletarNomeSobrenome();
                    break;
                }
            case "4": 
                { 
                    Console.Clear(); 
                    Metodos.GerarNomeAleatorio(); 
                    break; 
                }
            case "5": 
                { 
                    Console.Clear(); 
                    Metodos.ListarNomes(); 
                    break; 
                }
            case "6":
                {
                    return;
                    break;
                }
            default:
                {
                    Console.Clear();
                    Console.WriteLine("Opção INVALIDA!!!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Menu();
                    break;
                }
        }
        
    }
}