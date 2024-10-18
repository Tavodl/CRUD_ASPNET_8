using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Pages.Empleado
{
    public class CreateEmpleado : PageModel
    {
        private readonly AppDbContext context;

        public CreateEmpleado(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleados Empleados { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            context.Empleados.Add(Empleados);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
