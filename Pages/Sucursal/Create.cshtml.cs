using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Sucursal
{
    public class CreateSucursal : PageModel
    {
        private readonly AppDbContext context;

        public CreateSucursal(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sucursales Sucursales { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            context.Sucursales.Add(Sucursales);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
