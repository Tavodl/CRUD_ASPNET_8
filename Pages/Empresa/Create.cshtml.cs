using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empresa
{
    public class CreateEmpresa : PageModel
    {
        private readonly AppDbContext context;

        public CreateEmpresa(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empresas Empresas { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            context.Empresas.Add(Empresas);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
