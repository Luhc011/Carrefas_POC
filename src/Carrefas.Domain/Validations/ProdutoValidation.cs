using Carrefas.Domain.Models;
using FluentValidation;

namespace Carrefas.Domain.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser preenchido!")
                .Length(2, 30)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Descricao)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser preenchido!")
                .Length(2, 150)
                .WithMessage("O campo {PropertyName} precisa ter entre {MinLenght} e {MaxLenght}!");

            RuleFor(c => c.Valor)
                .GreaterThan(0)
                .WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}
