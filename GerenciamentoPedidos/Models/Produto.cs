using System.ComponentModel.DataAnnotations;

namespace GerenciamentoPedidos.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        public string Categoria { get; set; } = string.Empty;
    }
}
