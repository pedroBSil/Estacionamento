using System;
using System.Collections.Generic;
using System.Linq;

namespace JPCAR
{
    internal class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoHora;
        private List<string> veiculos;

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
            this.veiculos = new List<string>();
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo:");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Já existe um veiculo com essa placa.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veiculo cadastrado com sucesso.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo:");
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo ficou no pátio:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal precoTotal = precoInicial + precoHora * horas;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo de placa: {placa} foi removido e deve pagar {precoTotal}.");
            }
            else
            {
                Console.WriteLine("O veiculo não foi encontrado no pátio.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados são:");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos no pátio.");
            }
        }
    }
}
