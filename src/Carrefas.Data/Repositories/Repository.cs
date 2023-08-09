using Carrefas.Data.Context;
using Carrefas.Domain.Interfaces.Repositories;
using Carrefas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Carrefas.Data.Repositories
{
    public abstract class Repository<TModels> : IRepository<TModels> where TModels : Entity
    {
        protected readonly CarrefasContext Db;
        protected readonly DbSet<TModels> DbSet;

        protected Repository(CarrefasContext db)
        {
            Db = db;
            DbSet = db.Set<TModels>();
        }

        public async Task Adicionar(TModels entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(TModels entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }

        public async Task<IEnumerable<TModels>> Buscar(Expression<Func<TModels, bool>> Linq)
        {
            return await DbSet.AsNoTracking().Where(Linq).ToListAsync();
        }      

        public async Task<TModels> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task<List<TModels>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
