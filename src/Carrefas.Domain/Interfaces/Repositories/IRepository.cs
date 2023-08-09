using System.Linq.Expressions;
using Carrefas.Domain.Models;

namespace Carrefas.Domain.Interfaces.Repositories
{
    public interface IRepository<TModels> : IDisposable where TModels : Entity
    {
        Task Adicionar(TModels entity);
        Task<TModels> ObterPorId(Guid id);
        Task<List<TModels>> ObterTodos();
        Task Atualizar(TModels entity);       
        Task Remover(Guid id);
        Task<IEnumerable<TModels>> Buscar(Expression<Func<TModels, bool>> predicate);
        Task<int> SaveChanges();
    }
}
