using InterpackEmbalagens.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterpackEmbalagens.Pages.Estoques
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext context;
        public DeleteModel(ApplicationDbContext context)
        {
            this.context = context;
        }


        public string confirmacaoDeletar = "";
        public IActionResult OnGet(int id)
        {
            var estoque = context.Estoques.Find(id);
            if (estoque != null) {
                context.Estoques.Remove(estoque);
                context.SaveChanges();
            }
            


            return RedirectToPage("/Estoques/Index");

        }
    }
}
