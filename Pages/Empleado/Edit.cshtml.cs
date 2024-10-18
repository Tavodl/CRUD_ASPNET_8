using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empleado
{
    public class EditEmpleado : PageModel
    {
        private readonly AppDbContext context;

        public EditEmpleado(AppDbContext context)
        {
            this.context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            context.Empleados.Update(Empleados);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
