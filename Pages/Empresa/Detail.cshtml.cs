using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empresa
{
    public class DetailModel : PageModel
    {
        private readonly AppDbContext context;

        public DetailModel(AppDbContext context)
        {
            this.context = context;
        }

        public Empresas Empresas { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return RedirectToPage("./Index");
            }

            var empresas = await context.Empresas.FirstOrDefaultAsync(e => e.EmpresaId == id);

            if(empresas == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Empresas = empresas;
                return Page();
            }
        }
    }
}
