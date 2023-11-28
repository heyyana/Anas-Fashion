using System.ComponentModel.DataAnnotations;

namespace Anas_Fashion.Models
{
	public class VendedorModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Digite o campo nome!")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Digite o campo email!")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Digite o campo telefone!")]
		public string Telefone { get; set; }

		[Required(ErrorMessage = "Digite o campo endereço!")]
		public string Endereco { get; set; }
	}
}
