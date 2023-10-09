using System.ComponentModel;
using Estacionamento.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

string opcao = string.Empty;
bool escolherVeiculo = true;
while (escolherVeiculo)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Carro");
    Console.WriteLine("2 - Moto");

    switch (Console.ReadLine())
    {
        case "1":
            precoInicial = 5;
            precoPorHora = 3;
            Console.WriteLine($"O Valor Inicial para Carros é: R${precoInicial},00\nO Valor da Hora para Carros é: R${precoPorHora},00");
            Console.WriteLine("Pressione uma Enter para continuar");
            Console.ReadLine();
            escolherVeiculo = false;
            break;

        case "2":
            precoInicial = 3;
            precoPorHora = 2;
            Console.WriteLine($"O Valor Inicial para Motos é: R${precoInicial},00\nO Valor da Hora para Motos é: R${precoPorHora},00");
            Console.WriteLine("Pressione uma Enter para continuar");
            Console.ReadLine();
            escolherVeiculo = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            Console.WriteLine("Digite, uma opção válida:");
            Console.WriteLine("Pressione uma Enter para continuar");
            Console.ReadLine();           
            break;
    }
}
// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estaciona estaciona = new Estaciona(precoInicial, precoPorHora);

opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            estaciona.AdicionarVeiculo();
            break;

        case "2":
            estaciona.RemoverVeiculo();
            break;

        case "3":
            estaciona.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");