using Anas_Fashion.Data;
using Anas_Fashion.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anas_Fashion.Controllers
{
    public class FornecedorController : Controller
    {
        readonly private ApplicationDbContext _db;

        public FornecedorController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<FornecedorModel> fornecedores = _db.Fornecedores;
            return View(fornecedores);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(FornecedorModel fornecedores)
        {
            if (ModelState.IsValid)
            {
                _db.Fornecedores.Add(fornecedores);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FornecedorModel fornecedor = _db.Fornecedores.FirstOrDefault(x => x.Id == id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult Editar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _db.Fornecedores.Update(fornecedor);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FornecedorModel fornecedor = _db.Fornecedores.FirstOrDefault(x => x.Id == id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        [HttpPost]
        public IActionResult Excluir(FornecedorModel fornecedor)
        {
            if (fornecedor == null)
            {
                return NotFound();
            }

            _db.Fornecedores.Remove(fornecedor);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
