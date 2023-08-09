using Carrefas.Application.ViewModels;

namespace Carrefas.Application.Interfaces
{
    public interface IProdutoApplicationService
    {
        Task AdicionarProduto(ProdutoViewModel produtoViewModel);
        Task AtualizarProduto(ProdutoViewModel produtoViewModel);
        Task RemoverProduto(Guid id);

    }
}
