using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empleado
{
    public class IndexEmpleado : PageModel
    {
        private readonly AppDbContext context;

        public IndexEmpleado(AppDbContext context)
        {
            this.context = context;
        }
        public IList<Empleados> Empleados { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Empleados = await context.Empleados.ToListAsync();
        }
    }
}
