using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empresa
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext context;

        public IndexModel(AppDbContext context)
        {
            this.context = context;
        }
        public IList<Empresas> Empresas { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Empresas = await context.Empresas.ToListAsync();
        }
    }
}
