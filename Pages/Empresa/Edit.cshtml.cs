using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empresa
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext context;

        public EditModel(AppDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            context.Empresas.Update(Empresas);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
