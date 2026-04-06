using System.IO;
using System.Threading;
using System;

namespace desafio1;

public class Metodos
{
    public static void InserirNome()
    {
        Console.WriteLine("Qual o nome você deseja colocar no arquivo?");
        string nome = Console.ReadLine();

        if (string.IsNullOrEmpty(nome))
        {
            Console.WriteLine("O sobrenome que você deu é invalido ou nullo!");
            Thread.Sleep(900);
            Console.Clear();
            InserirNome();
        }
        else
        {

            string nomeF = char.ToUpper(nome[0]) + nome.Substring(1).ToLower();

            string caminhoArquivo = $@"E:\Desenvolvimento\Desafio1\nome.txt";
            File.AppendAllText(caminhoArquivo, $"{nomeF}" + Environment.NewLine);
        }
    }

    public static void InserirSobrenome()
    {
        Console.WriteLine("Qual o sobrenome você deseja colocar no arquivo?");
        string sobrenome = Console.ReadLine();
        if (string.IsNullOrEmpty(sobrenome))
        {
            Console.WriteLine("O sobrenome que você deu é invalido ou nullo!");
            Thread.Sleep(900);
            Console.Clear();
            InserirSobrenome();
        }
        else
        {

            string sobrenomeF = char.ToUpper(sobrenome[0]) + sobrenome.Substring(1).ToLower();

            string caminhoArquivo = $@"E:\Desenvolvimento\Desafio1\sobrenome.txt";
            File.AppendAllText(caminhoArquivo, $"{sobrenomeF}" + Environment.NewLine);
        }
    }

    public static void DeletarNomeSobrenome()
    {
        Console.WriteLine("O que você quer deletar?");
        Console.WriteLine("1) - Nome");
        Console.WriteLine("2) - Sobrenome");
        string opNomeSobrenome = Console.ReadLine();

        //if (opnomesobrenome == 1)
        //{

        //}
        //else if (opnomesobrenome == 2)
        //{

        //}
        //else
        //{
        //    console.writeline("operação invalida");
        //    thread.sleep(800);
        //    console.clear();
        //    thread.sleep(800);
        //    deletarnomesobrenome();
        //}
    }
    public static void GerarNomeAleatorio()
    {

    }
}
