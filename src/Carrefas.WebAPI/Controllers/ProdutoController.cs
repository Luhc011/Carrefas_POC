using Microsoft.AspNetCore.Mvc;

namespace Carrefas.WebAPI.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
