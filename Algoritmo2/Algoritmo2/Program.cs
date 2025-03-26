using System.Runtime.CompilerServices;

int idade = 10;
string nomeCliente = "Erick Borges";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Erick Borges Rodrigues";
var altura = 167;

Console.WriteLine("Digite seu nome:");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo " + nomeCompleto);
Console.Write("Digite sua idade: ");
var linha = Console.ReadLine();
idade = int.Parse(linha);
Console.WriteLine("idade informada" + idade);
if (idade < 18)
    Console.WriteLine("Você não pode estar aqui");

Console.ReadKey();