using System.ComponentModel.DataAnnotations;

namespace Carrefas.Application.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string? Nome { get; set; }

        [StringLength(150, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo {0} deve conter um valor decimal válido")]
        public decimal Valor { get; set; }

        public bool Ativo { get; set; }
    }
}


/* 
 * RegEx - decimal Valor:
 * Essa expressão regular garante que o valor digitado seja um número decimal válido, permitindo, por exemplo, 
 * "10", "10.5" e "10.50", mas não permitindo "abc", "10." ou "10.555".
 */