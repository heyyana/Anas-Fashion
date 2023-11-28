using System.ComponentModel.DataAnnotations;

namespace Anas_Fashion.Models
{
    public class FornecedorModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome da Empresa!")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Digite o CPNJ!")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Digite o endereço!")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Digite o telefone!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o email!")]
        public string Email { get; set; }
    }
}
