using System;
using models;

Estacionamento estacionamento = new Estacionamento();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

/*CONFIGURAÇÃO INICIAL*/
Console.WriteLine("Digite o valor inicial para estacionar:");
float valorInicial = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor por hora para estacionar:");
float valorPorHora = float.Parse(Console.ReadLine());
estacionamento.ValorInicial = valorInicial;
estacionamento.ValorPorHora = valorPorHora;

/*MENU*/
string opcao = "";
while (opcao != "4") {
    Console.Clear();
    Console.WriteLine(@"Digite uma opição:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar progrma
");

    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo para cadastrar:");
            string placa = Console.ReadLine();
            estacionamento.AdicionarVeiculo(placa);
            break;
        case "2":
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placaRemover = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de horas que o veículo ficou estacionado:");
            int horas = int.Parse(Console.ReadLine());
            estacionamento.RemoverVeiculo(placaRemover, horas);
            break;
        case "3":
            estacionamento.ListarVeiculos();
            break;
        case "4":
            Console.WriteLine("Encerrando programa...");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
    Console.WriteLine("Pressione Enter para continuar...");
    Console.ReadLine();
} 