namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
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
    string placa = Console.ReadLine();

    // Verifica se a placa contém tanto letras quanto números
    if (PlacaValida(placa))
    {
        // Adiciona a placa à lista de veículos
        veiculos.Add(placa);
        Console.WriteLine($"O veículo com a placa {placa} foi estacionado com sucesso!");
    }
    else
    {
        Console.WriteLine("Está placa é inválida. Certifique-se de que a placa contém letras e números.");
    }
}

// Método auxiliar para verificar se a placa é válida
private bool PlacaValida(string placa)
{
    // Verifica se a placa contém pelo menos uma letra e um número
    return placa.Any(char.IsLetter) && placa.Any(char.IsDigit);
}

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Verifique se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                     Console.WriteLine(veiculo);
                }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
