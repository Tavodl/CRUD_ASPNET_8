using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Sucursal
{
    public class EditSucursal : PageModel
    {
        private readonly AppDbContext context;

        public EditSucursal(AppDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public Sucursales Sucursales { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return RedirectToPage("./Index");
            }

            var sucursales = await context.Sucursales.FirstOrDefaultAsync(e => e.SucursalId == id);

            if(sucursales == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Sucursales = sucursales;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            context.Sucursales.Update(Sucursales);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
