using Carrefas.Application.Interfaces;
using Carrefas.Application.ViewModels;
using Carrefas.Domain.Interfaces.Services;
using Carrefas.Domain.Models;

namespace Carrefas.Application.Services
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoApplicationService(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public Task AdicionarProduto(ProdutoViewModel produtoViewModel)
        {
            var produto = new Produto(produtoViewModel.Nome,    
                                      produtoViewModel.Descricao,
                                      produtoViewModel.Valor,
                                      produtoViewModel.Ativo);

            return _produtoService.AdicionarProduto(produto);
        }

        public Task AtualizarProduto(ProdutoViewModel produtoViewModel)
        {
            throw new NotImplementedException();
        }

        public Task RemoverProduto(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
