using Anas_Fashion.Data;
using Anas_Fashion.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anas_Fashion.Controllers
{
	public class VendedorController : Controller
	{
		readonly private ApplicationDbContext _db;

		public VendedorController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<VendedorModel> vendedores = _db.Vendedores;
			return View(vendedores);
		}

		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar(VendedorModel vendedor)
		{
			if (ModelState.IsValid)
			{
				_db.Vendedores.Add(vendedor);
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

			VendedorModel vendedor = _db.Vendedores.FirstOrDefault(x => x.Id == id);

			if (vendedor == null)
			{
				return NotFound();
			}

			return View(vendedor);
		}

		[HttpPost]
		public IActionResult Editar(VendedorModel vendedor)
		{
			if (ModelState.IsValid)
			{
				_db.Vendedores.Update(vendedor);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}
			return View(vendedor);
		}

		[HttpGet]
		public IActionResult Excluir(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			VendedorModel vendedor = _db.Vendedores.FirstOrDefault(x => x.Id == id);

			if (vendedor == null)
			{
				return NotFound();
			}

			return View(vendedor);
		}

		[HttpPost]
		public IActionResult Excluir(VendedorModel vendedor)
		{
			if (vendedor == null)
			{
				return NotFound();
			}

			_db.Vendedores.Remove(vendedor);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
