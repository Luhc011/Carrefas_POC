using Carrefas.Domain.Interfaces.Notifications;
using Carrefas.Domain.Interfaces.Repositories;
using Carrefas.Domain.Interfaces.Services;
using Carrefas.Domain.Models;
using Carrefas.Domain.Validations;

namespace Carrefas.Domain.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(INotifier notifier, IProdutoRepository produtoRepository) : base(notifier)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task AdicionarProduto(Produto produto)
        {
            if (!RunValidation(new ProdutoValidation(), produto)) return;

            if (_produtoRepository.BuscarProduto(p => p.Nome == produto.Nome).Result.Any())
            {
                Notify("Já existe um produto cadastrado com este nome");
                return;
            }

            produto.Ativar();

            await _produtoRepository.AdicionarProduto(produto);
        }

        public async Task AtualizarProduto(Produto produto)
        {
            await _produtoRepository.Atualizar(produto);
        }

        public async Task RemoverProduto(Guid id)
        {
            await _produtoRepository.RemoverProduto(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}

/*
 
     DESAFIO:

      Implementar na classe ProdutoService os metodos: AtualizarProduto e RemoverProduto
    
    - Utilizando interfaces IProdutoService e IProdutoRepository
    - Utilizando Repositorio especificado 

       Tempo: 30min.
     
      dica: Analise a implementação AdicionarProduto
 
 */