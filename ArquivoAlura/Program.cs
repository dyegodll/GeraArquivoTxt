using ArquivoAlura.Models;
using ArquivoAlura.Util;

Console.WriteLine(@"
░█▀▀█ █▀▀ █▀▀█ █▀▀█ 　 ─█▀▀█ █▀▀█ █▀▀█ █──█ ─▀─ ▀█─█▀ █▀▀█ 　 ░█▀▀█ █▀▀ █▀▀ █▀▀ █▀▀█ █▀▀█ 
░█─▄▄ █▀▀ █▄▄▀ █▄▄█ 　 ░█▄▄█ █▄▄▀ █──█ █──█ ▀█▀ ─█▄█─ █──█ 　 ░█▄▄█ █▀▀ ▀▀█ ▀▀█ █──█ █▄▄█ 
░█▄▄█ ▀▀▀ ▀─▀▀ ▀──▀ 　 ░█─░█ ▀─▀▀ ▀▀▀█ ─▀▀▀ ▀▀▀ ──▀── ▀▀▀▀ 　 ░█─── ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀▀ ▀──▀");
Console.WriteLine("\nDADOS DA PESSOA:");

Console.Write("\nInforme o Nome: ");
string nome = Console.ReadLine()!;

Console.Write("\nInforme a Idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("\nInforme o E-mail: ");
string email = Console.ReadLine()!;

Pessoa pessoa = new Pessoa(nome,idade,email);

GeradorArquivoPessoa.GeraArquivoTXT(pessoa);