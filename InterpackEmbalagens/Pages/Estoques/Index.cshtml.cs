using InterpackEmbalagens.Models;
using InterpackEmbalagens.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterpackEmbalagens.Pages.Estoques
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<Estoque> estoqueLst = new();

        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            estoqueLst = context.Estoques.OrderByDescending(i => i.Id).ToList();
        }
    }
}
