using Microsoft.EntityFrameworkCore;

namespace InterpackEmbalagens.Models
{
    public class Estoque
    {
        public int Id { get; set; }

        public string Numero { get; set; } = "";
        public string Status { get; set; } = ""; // pago ou pendente
        public DateOnly? DataEmissao { get; set; }
        public DateOnly? DataVencimento { get; set; }

        public string Servico { get; set; } = "";
        [Precision(16, 2)]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public string NomeCliente { get; set; } = "";
        public string Email { get; set; } = "";
        public string Celular { get; set; } = "";
        public string Endereco { get; set; } = "";
    }
}
