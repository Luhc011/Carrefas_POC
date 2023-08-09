using Carrefas.Data.Context;
using Carrefas.Domain.Interfaces.Repositories;
using Carrefas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Carrefas.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(CarrefasContext db) : base(db)
        {
        }

        public async Task AdicionarProduto(Produto produto)
        {
            await Adicionar(produto);
        }

        public async Task AtualizarProduto(Produto produto)
        {
            await Atualizar(produto);
        }

        public async Task<IEnumerable<Produto>> BuscarProduto(Expression<Func<Produto, bool>> expression)
        {
            return await Db.Produtos.AsNoTracking().Where(expression).ToListAsync();
        }

        public async Task RemoverProduto(Guid id)
        {
            await Remover(id);
        }
    }
}
