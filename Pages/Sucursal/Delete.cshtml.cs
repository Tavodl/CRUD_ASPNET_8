using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Sucursal
{
    public class DeleteSucursal : PageModel
    {
        private readonly AppDbContext context;

        public DeleteSucursal(AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if(id==null)
            {
                return Page();
            }

            var sucursales = await context.Sucursales.FindAsync(id);

            if(sucursales == null)
            {
                return Page();
            }
            else
            {
                Sucursales = sucursales;
                context.Sucursales.Remove(Sucursales);
                await context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
        }
    }
}
