using Microsoft.AspNetCore.Mvc;
using InventoryQuickCRUD.Data;
using InventoryQuickCRUD.Models;
using Microsoft.AspNetCore.Http;


namespace InventoryQuickCRUD.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpleadosController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: EmployeesController
        public ActionResult Index()
        {
            IEnumerable<Empleado> colEmpleados = _context.Empleados.Where(s => s.Estate == true);// Código refactorizado para retornar 
            return View(colEmpleados);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empleado empleado)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    _context.Employees.Add(empleado);
                    _context.SaveChanges();
                    TempData["ResultOk"] = "Datos agregados satisfactoriamente";

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();//empobj
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empleadofromdb = _context.Empleados.Find(id);
            if (empleadofromdb == null)
            {
                return NotFound();
            }
            return View(empleadofromdb);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empleado empleado)
        {


            try
            {
                if (ModelState.IsValid)
                {
                    _context.Empleados.Update(empleado);
                    _context.SaveChanges();
                    TempData["ResultOk"] = "Datos actualizados satisfactoriamente";

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();//empobj
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            var empleadofromdb = _context.Empleados.Find(id);
            if (empleadofromdb == null)
            {
                return NotFound();
            }
            return View(empleadofromdb);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {

            try
            {
                var empleadofromdb = _context.Empleados.Find(id);




                if (empleadofromdb == null)
                {
                    return NotFound();

                }
                // _context.Employees.Remove(employeefromdb); // Refactorizado para inactivar el usuario. No eliminarlo 
                empleadofromdb.Estate = false;
                _context.Empleados.Update(empleadofromdb);

                _context.SaveChanges();
                TempData["ResultOk"] = "Datos eliminados satisfactoriamente";
                return RedirectToAction("Index");
            }
            catch
            {
                return View(); //empobj
            }
        }
    }
   
}
