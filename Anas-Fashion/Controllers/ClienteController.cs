using Anas_Fashion.Data;
using Anas_Fashion.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anas_Fashion.Controllers
{
	public class ClienteController : Controller
	{
		readonly private ApplicationDbContext _db;

		public ClienteController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<ClienteModel> clientes = _db.Clientes;
			return View(clientes);
		}

		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar(ClienteModel cliente)
		{
			if (ModelState.IsValid)
			{
				_db.Clientes.Add(cliente);
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

			ClienteModel cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

			if (cliente == null)
			{
				return NotFound();
			}

			return View(cliente);
		}

		[HttpPost]
		public IActionResult Editar(ClienteModel cliente)
		{
			if (ModelState.IsValid)
			{
				_db.Clientes.Update(cliente);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}
			return View(cliente);
		}

		[HttpGet]
		public IActionResult Excluir(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			ClienteModel cliente = _db.Clientes.FirstOrDefault(x => x.Id == id);

			if (cliente == null)
			{
				return NotFound();
			}

			return View(cliente);
		}

		[HttpPost]
		public IActionResult Excluir(ClienteModel cliente)
		{
			if (cliente == null)
			{
				return NotFound();
			}

			_db.Clientes.Remove(cliente);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
