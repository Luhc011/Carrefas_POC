using Carrefas.Domain.Models;
using System.Linq.Expressions;

namespace Carrefas.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>, IDisposable
    {
        Task AdicionarProduto(Produto produto);
        Task AtualizarProduto(Produto produto);
        Task RemoverProduto(Guid id);
        Task<IEnumerable<Produto>> BuscarProduto(Expression<Func<Produto, bool>> expression);
    }
}
