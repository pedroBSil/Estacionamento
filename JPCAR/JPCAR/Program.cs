using System;

namespace JPCAR
{
    class Program
    {
        static void Main()
        {
            decimal precoInicial = 0;
            decimal precoHora = 0;

            Console.WriteLine("Seja bem-vindo ao Estacionamento do João");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Digite o preço Inicial");
            precoInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Agora digite o preço por hora");
            precoHora = Convert.ToDecimal(Console.ReadLine());

            Estacionamento es = new Estacionamento(precoInicial, precoHora);

            bool menu = true;

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1 - Adicionar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Sair");

                switch (Console.ReadLine())
                {
                    case "1":
                        es.AdicionarVeiculo();
                        break;

                    case "2":
                        es.RemoverVeiculo();
                        break;

                    case "3":
                        es.ListarVeiculos();
                        break;

                    case "4":
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
