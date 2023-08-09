using Carrefas.Domain.Models;

namespace Carrefas.Domain.Interfaces.Services
{
    public interface IProdutoService : IDisposable
    {
        Task AdicionarProduto(Produto produto);
        Task AtualizarProduto(Produto produto);
        Task RemoverProduto(Guid id);
    }
}
