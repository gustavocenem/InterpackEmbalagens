using InterpackEmbalagens.Models;
using InterpackEmbalagens.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterpackEmbalagens.Pages.Estoques
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public EstoqueDto EstoqueDto { get; set; } = new EstoqueDto();

        public Estoque Estoque { get; set; } = new();


        private readonly ApplicationDbContext context;

        public EditarModel(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IActionResult OnGet(int id)
        {
            var estoque = context.Estoques.Find(id);
            if (estoque == null)
            {
                return RedirectToPage("/Estoques/Index");
            }

            Estoque = estoque;

            EstoqueDto.Numero = estoque.Numero;
            EstoqueDto.Status = estoque.Status;
            EstoqueDto.DataEmissao = estoque.DataEmissao;
            EstoqueDto.DataVencimento = estoque.DataVencimento;

            EstoqueDto.Servico = estoque.Servico;
            EstoqueDto.Preco = estoque.Preco;
            EstoqueDto.Quantidade = estoque.Quantidade;

            EstoqueDto.NomeCliente = estoque.NomeCliente;
            EstoqueDto.Email = estoque.Email;
            EstoqueDto.Celular = estoque.Celular;
            EstoqueDto.Endereco = estoque.Endereco;

            return Page();
        }


        public string confirmacaoMsg = "";
        public IActionResult OnPost(int id)
        {
            var estoque = context.Estoques.Find(id);
            if (estoque == null)
            {
                return RedirectToPage("/Estoques/Index");
            }

            Estoque = estoque;

            if (!ModelState.IsValid)
            {
                return Page();
            }


            estoque.Numero = EstoqueDto.Numero;
            estoque.Status = EstoqueDto.Status;
            estoque.DataEmissao = EstoqueDto.DataEmissao;
            estoque.DataVencimento = EstoqueDto.DataVencimento;

            estoque.Servico = EstoqueDto.Servico;
            estoque.Preco = EstoqueDto.Preco;
            estoque.Quantidade = EstoqueDto.Quantidade;

            estoque.NomeCliente = EstoqueDto.NomeCliente;
            estoque.Email = EstoqueDto.Email;
            estoque.Celular = EstoqueDto.Celular;
            estoque.Endereco = EstoqueDto.Endereco;

            context.SaveChanges();

            confirmacaoMsg = "Fatura atualizada com sucesso!";

            return Page();
        }
    }
}
