using System.Text.RegularExpressions;

namespace Estacionamento.Models
{
    public class ValidarPlaca
    {
        public bool ValidaPlaca(string placa)
        {
            // O padrão brasileiro de placa de veículo é ABC1D23 ou 1D23ABC, onde ABC são letras e 1D23 são números.
            string padrao = @"^[A-Z]{3}\d{1}[A-Z]{1}\d{2}$|^\d{1}[A-Z]{1}\d{2}[A-Z]{1}$";
            //Segui algumas dicas e li a documentação para conseguir usar o Regex
            Regex regex = new Regex(padrao);

            return regex.IsMatch(placa);
        }
    }
}