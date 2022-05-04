using System.ComponentModel.DataAnnotations;

namespace Loja.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
