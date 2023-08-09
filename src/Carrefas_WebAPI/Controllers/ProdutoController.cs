using Carrefas.Application.Interfaces;
using Carrefas.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Carrefas_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoApplicationService _produtoApplicationService;
        public ProdutoController(IProdutoApplicationService produtoApplicationService)
        {
            _produtoApplicationService = produtoApplicationService;
        }

        [HttpPost]
        public async Task<ActionResult> AdicionarProduto(ProdutoViewModel produtoViewModel)
        {
            if (ModelState.IsValid)
                await _produtoApplicationService.AdicionarProduto(produtoViewModel);
            
            return Ok();
        }
    }
}
