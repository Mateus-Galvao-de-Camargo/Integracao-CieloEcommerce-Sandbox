using System.ComponentModel.DataAnnotations;

namespace TesteDaUmbler.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        public Cartao Cartao { get; set; } = null!;

        public string EstadoDaTransacao { get; set; } = null!;
    }
}
