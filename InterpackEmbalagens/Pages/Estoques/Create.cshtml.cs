using InterpackEmbalagens.Models;
using InterpackEmbalagens.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace InterpackEmbalagens.Pages.Estoques
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;

        [BindProperty]
        public EstoqueDto EstoqueDto { get; set; } = new();


        public CreateModel(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var estoque = new Estoque
            {
                Numero           = EstoqueDto.Numero,
                Status           = EstoqueDto.Status,
                DataEmissao      = EstoqueDto.DataEmissao,
                DataVencimento   = EstoqueDto.DataVencimento,

                Servico          = EstoqueDto.Servico,
                Preco            = EstoqueDto.Preco,
                Quantidade       = EstoqueDto.Quantidade,

                NomeCliente      = EstoqueDto.NomeCliente,
                Email            = EstoqueDto.Email,
                Celular          = EstoqueDto.Celular,
                Endereco         = EstoqueDto.Endereco,
            };

            context.Estoques.Add(estoque);
            context.SaveChanges();

            return RedirectToPage("/Estoques/Index");
        }
    }
}
