// Screen Sound
using System;

String mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n1 - Registrar banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Avaliar banda");
    Console.WriteLine("4 - Exibir media da banda");
    Console.WriteLine("0 - Sair do programa");
    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; // ! Utilizado para ReadLine não trabalhar com valor nulo
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); // int.Parse converte uma variável do tipo string em inteiro

    if (opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidaNumerica == 2)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidaNumerica == 3)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidaNumerica == 4)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else
    {
        Console.WriteLine("Programa Encerrado!");
    }
}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();