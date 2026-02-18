using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Contatos.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public required string Nome { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "O email deve ser um endereço de email válido.")]
        public required string  Email { get; set; }
        [Phone]
        public required string ?Telefone { get; set; }
    }
}
