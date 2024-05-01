using System.Reflection.Metadata;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private int totalVeiculos = 0;
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
            totalVeiculos++;
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            bool verdade = true;
            string placa = "";
            placa = Console.ReadLine();

            if(totalVeiculos < 0){
                while(verdade == true){
                    for(int i=0; i< totalVeiculos; i++){
                        if(veiculos[i] == placa){
                            veiculos.Remove(placa);
                        }
                    }
                    verdade = false;
                }
                totalVeiculos--;
            }

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0; 

                while(horas == 0){
                    horas = Convert.ToInt32(Console.ReadLine());
                }

                valorTotal = precoInicial + precoPorHora * horas;

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                for(int i=0; i<totalVeiculos; i++){
                    Console.WriteLine(veiculos[i]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
