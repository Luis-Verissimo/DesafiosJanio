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
        int verificaNumero;

        if (string.IsNullOrEmpty(nome) || int.TryParse(nome, out verificaNumero)) //Verificando se o nome é nullo/vazio
        {
            Console.WriteLine("O nome que você deu é invalido!");
            Thread.Sleep(900);
            Console.Clear();
            InserirNome();
        }
        else
        {
            string nomeSemEspaco = nome.Replace(" ", "");
            string nomeF = char.ToUpper(nomeSemEspaco[0]) + nomeSemEspaco.Substring(1).ToLower(); //Transformando a primeira letra em maiuscula

            if (File.Exists(nomeF))
            {
                Console.WriteLine("Nome já cadastrado!");
                Thread.Sleep(900);
                Console.Clear();
                InserirNome();
            }
            else
            {
                string caminhoArquivo = $@"E:\Desenvolvimento\DasafiosJanio\Desafio1\nome.txt"; //Alterar o output do arquivo
                File.AppendAllText(caminhoArquivo, $"{nomeF}" + Environment.NewLine);

            }
        }
    }

    public static void InserirSobrenome()
    {
        Console.WriteLine("Qual o sobrenome você deseja colocar no arquivo?");
        string sobrenome = Console.ReadLine();
        int verificaNumero;

        if (string.IsNullOrEmpty(sobrenome) || int.TryParse(sobrenome, out verificaNumero)) //Verificando se o nome é nullo/vazio
        {
            Console.WriteLine("O sobrenome que você deu é invalido ou nullo!");
            Thread.Sleep(900);
            Console.Clear();
            InserirSobrenome();
        }
        else
        {
            string sobrenomeSemEspaco = sobrenome.Replace(" ", "");
            string sobrenomeF = char.ToUpper(sobrenomeSemEspaco[0]) + sobrenomeSemEspaco.Substring(1).ToLower(); //Transformando a primeira letra em maiuscula

            if (File.Exists(sobrenome))
            {
                Console.WriteLine("Sobrenome já cadastrado!");
                Thread.Sleep(900);
                Console.Clear();
                InserirSobrenome();
            }
            else
            {
                string caminhoArquivo = $@"E:\Desenvolvimento\DasafiosJanio\Desafio1\sobrenome.txt"; //Alterar o output do arquivo 
                File.AppendAllText(caminhoArquivo, $"{sobrenomeF}" + Environment.NewLine);
            }
        }
    }

    public static void DeletarNomeSobrenome()
    {
        Console.WriteLine("O que você quer deletar?");
        Console.WriteLine("1) - Nome");
        Console.WriteLine("2) - Sobrenome");
        string opNomeSobrenome = Console.ReadLine();

        if (opNomeSobrenome == "1")
        {
           
        }
        else if (opNomeSobrenome == "2")
        {

        }
        else
        {
            Console.WriteLine("operação invalida");
            Thread.Sleep(800);
            Console.Clear();
            Thread.Sleep(800);
            DeletarNomeSobrenome();
        }
    }
    public static void GerarNomeAleatorio()
    {

    }

    public static void ListarNomes()
    {
        string caminhoArquivo = $@"E:\Desenvolvimento\DasafiosJanio\Desafio1\";
        string nomesArquivos = File.ReadAllText(caminhoArquivo);
        foreach (var item in nomesArquivos) 
        {
            Console.WriteLine(nomesArquivos);
        }
    }
}