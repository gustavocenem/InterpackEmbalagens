using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InterpackEmbalagens.Models
{
    public class EstoqueDto
    {
        [Required]
        public string Numero { get; set; } = "";
        [Required]
        public string Status { get; set; } = ""; // pago, pendente ou cancelado
        public DateOnly? DataEmissao { get; set; }
        public DateOnly? DataVencimento { get; set; }

        [Required]
        public string Servico { get; set; } = "";
        [Range(1, 999999, ErrorMessage = "Preço inválido!")]
        public decimal Preco { get; set; }
        [Range(1, 99)]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Nome do cliente inválido!")]
        public string NomeCliente { get; set; } = "";
        [Required, EmailAddress]
        public string Email { get; set; } = "";
        [Phone]
        public string Celular { get; set; } = "";
        public string Endereco { get; set; } = "";
    }
}
