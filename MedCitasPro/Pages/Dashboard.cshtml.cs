using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages
{
    public class DashboardModel : PageModel
    {
        [BindProperty]
        public string Role { get; set; }

        public IActionResult OnGet(string role)
        {
            if (string.IsNullOrEmpty(role))
            {
                // Si falta el rol, redirige al inicio de sesi�n
                return RedirectToPage("/Login");
            }

            Role = role;
            return Page();
        }

    }
}
