using System;
using System.Collections.Generic;

namespace models
{
    public class Estacionamento
    {
        private float _valorInicial;
        public float ValorInicial
        {
            get => _valorInicial;
           set
            {
                if (value < 0)
                    throw new ArgumentException("Valor inicial não pode ser negativo.");
                _valorInicial = value;
            }
        }

        private float _valorPorHora;
        public float ValorPorHora
        {
            get => _valorPorHora;
           set
            {
                if (value < 0)
                    throw new ArgumentException("Valor por hora não pode ser negativo.");
                _valorPorHora = value;
            }
        }

        private List<string> Veiculos = new List<string>();

        public void AdicionarVeiculo(string placa)
        {
            if(placa == null || placa == "")
                throw new ArgumentException("Placa não pode ser nula ou vazia.");
            Veiculos.Add(placa);
            Console.WriteLine($"O veículo {placa} foi adicionado.");
        }
        public void RemoverVeiculo(string placa, int horas)
        {
            if(placa == null || placa == "")
                throw new ArgumentException("Placa não pode ser nula ou vazia.");
            if(horas < 0)
                throw new ArgumentException("Horas não pode ser negativo.");
            if (Veiculos.Contains(placa))
            {
                Veiculos.Remove(placa);
                float valorTotal = ValorInicial + (ValorPorHora * horas);
                Console.WriteLine($"O veículo {placa} foi removido. O valor total a pagar é: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }
        public void ListarVeiculos()
        {
            if (Veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            else
            {
                Console.WriteLine("Veículos estacionados:");
                foreach (var veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
        }   
    }
}