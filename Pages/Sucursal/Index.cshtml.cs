using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Sucursal
{
    public class IndexSucursal : PageModel
    {
        private readonly AppDbContext context;

        public IndexSucursal(AppDbContext context)
        {
            this.context = context;
        }
        public IList<Sucursales> Sucursales { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Sucursales = await context.Sucursales.ToListAsync();
        }
    }
}
