using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empleado
{
    public class DetailEmpleado : PageModel
    {
        private readonly AppDbContext context;

        public DetailEmpleado(AppDbContext context)
        {
            this.context = context;
        }

        public Empleados Empleados { get; set; } = default!;
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return RedirectToPage("./Index");
            }

            var empleados = await context.Empleados.FirstOrDefaultAsync(e => e.EmpleadoId == id);

            if(empleados == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Empleados = empleados;
                return Page();
            }
        }
    }
}
