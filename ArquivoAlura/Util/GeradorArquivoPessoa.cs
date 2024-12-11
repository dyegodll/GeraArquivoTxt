using ArquivoAlura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquivoAlura.Util;

internal class GeradorArquivoPessoa
{
    public static void GeraArquivoTXT(Pessoa pessoa)
    {
        Console.Write("\nInforme o nome para o arquivo: ");
        string nomeArquivo = Console.ReadLine()!.Trim()+".txt";
        string[] firstName = pessoa.Nome.Split(' ');

        using (StreamWriter arquivo = new StreamWriter(nomeArquivo)) 
        {
            arquivo.WriteLine($"☻ Dados de {firstName[0]} ☻\n");

            arquivo.WriteLine($"Nome: {pessoa.Nome}");
            arquivo.WriteLine($"Idade: {pessoa.Idade}");
            arquivo.WriteLine($"E-mail: {pessoa.Email}");
        }
        Console.WriteLine($"\nArquivo {nomeArquivo} gerado com sucesso!");
        Console.WriteLine($"Salvo em {Path.GetFullPath(nomeArquivo)}");
    }
}