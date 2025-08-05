using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidos.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome � obrigat�rio")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email � obrigat�rio")]
        [EmailAddress(ErrorMessage = "Email inv�lido")]
        public string Email { get; set; } = string.Empty;
    }
}
