using Microsoft.AspNetCore.Mvc;

namespace InventoryQuickCRUD.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
