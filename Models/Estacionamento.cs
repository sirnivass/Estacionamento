namespace Estacionamento.Models

{
    public class Estaciona
    {
        private decimal precoInicial;
        private decimal precoPorHora ;
        private List<string> veiculos = new List<string>();
        private ValidarPlaca validarPlaca = new ValidarPlaca(); //instanciando validação de placas
        public Estaciona(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa;
            // Como padrão, vou aceitar somente o modelo ABC1D23.
            //Esse Loop irá parar somente quando uma placa válida seja fornecida:
            //Desenvolvi um loop parecido num projeto de C que fiz na faculdade, é simples, mas funciona...
            do
            {
                Console.WriteLine("Digite a placa do veículo para estacionar (No padrão ABC1D23): ");
                placa = Console.ReadLine();

                if (validarPlaca.ValidaPlaca(placa))
                {
                    veiculos.Add(placa);
                    Console.WriteLine($"Veículo com a placa {placa} foi estacionado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Placa inválida. Certifique-se de seguir o formato ABC1D23.");
                }
            // Continua pedindo até que uma placa válida seja fornecida, isso evita placas vazias ou nulas
            //do while (Mais sobre no material)
            }while (!validarPlaca.ValidaPlaca(placa)); 
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            //".Any" Método que verifica se pelo menos um elemento na coleção satisfaz a condição, no caso, a "plcaca".
            //ToUpper método que converte uma string para maiúsculas.
            //x representa o elemento na coleção, comparando assim, a Placa (Tudo em maiúsculo, pelo ToUpper).
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                //inicia a variável com 0
                int horas = 0;
                decimal valorTotal = 0; 

                if (int.TryParse(Console.ReadLine(), out horas))
                {
                    valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
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
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}