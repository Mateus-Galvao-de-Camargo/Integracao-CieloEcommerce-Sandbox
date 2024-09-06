using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TesteDaUmbler.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        public Cartao Cartao { get; set; } = null!;

        [Required(ErrorMessage = "Por favor, selecione um cartão válido.")]
        public int CartaoId { get; set; }

        [Required(ErrorMessage = "Por favor, insira um valor válido.")]
        public double Valor { get; set; }

        public string EstadoDaTransacao { get; set; } = null!;
    }
}
