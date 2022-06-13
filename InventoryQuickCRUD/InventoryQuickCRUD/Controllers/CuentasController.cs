using Microsoft.AspNetCore.Mvc;

namespace InventoryQuickCRUD.Controllers
{
    public class CuentasController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
