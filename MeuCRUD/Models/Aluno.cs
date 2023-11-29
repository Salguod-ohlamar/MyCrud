using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MeuCRUD.Models
{
    public class Aluno
    {


        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório! ")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = " O campo precisa ter enter {2} e {1} caracteres")]
        [Display(Name = "Nome")]
        public string? name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório! ")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo {0} esta em formato incorreto")]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório! ")]
        [StringLength(60, ErrorMessage = " O campo precisa ter enter {0} e no maximo {1} caracteres")]
        [RegularExpression(@"^[\w\.-]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "O campo {0} está em formato incorreto!")]

        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório! ")]
        [Display(Name = "Confirme o e-mail!")]
        [Compare("Email", ErrorMessage = "Os email informados nao sao identicos")]
        [NotMapped]
        public string? EmailConfirmacao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório! ")]
        [Range(1, 5, ErrorMessage = "O campo {0} deve estar entre {1} e {2}")]
        [Display(Name = "Avaliação")]
        public int? Avaliacao { get; set; }


        public bool Ativo { get; set; }
    }
}

