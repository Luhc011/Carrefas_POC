namespace Carrefas.Domain.Models
{
    public class Produto : Entity
    {
        public string? Nome { get; private set; }
        public string? Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public bool Ativo { get; private set; }

        public Produto(string? nome, string? descricao, decimal valor, bool ativo)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Ativo = ativo;
        }

        public void Ativar() => Ativo = true;
        public void Inativar() => Ativo = false;
    }
}
