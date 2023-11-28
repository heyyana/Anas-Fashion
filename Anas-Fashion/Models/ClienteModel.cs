using System.ComponentModel.DataAnnotations;

namespace Anas_Fashion.Models
{
	public class ClienteModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Digite o nome do cliente")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "Digite o email do cliente")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Digite o telefone do cliente")]
		public string Telefone { get; set; }

		[Required(ErrorMessage = "Digite o CPF do cliente")]
		public string CPF { get; set; }

		[Required(ErrorMessage = "Digite o endereço do cliente")]
		public string Endereco { get; set; }
	}
}
