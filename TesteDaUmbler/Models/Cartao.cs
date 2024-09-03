using System.ComponentModel.DataAnnotations;

namespace TesteDaUmbler.Models
{
    public class Cartao
    {
        [Key]
        public int Id { get; set; }

        public int NumeroDoCartao { get; set; }

        public int Cvc { get; set; }

        public DateTime Validade { get; set; }

        public string NomeNoCartao { get; set; } = null!;
    }
}
