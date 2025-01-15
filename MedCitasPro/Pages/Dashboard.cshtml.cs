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
            // Validar que el rol esté definido
            if (string.IsNullOrEmpty(role))
            {
                return RedirectToPage("/Login");
            }

            Role = role; // Asignar el rol al modelo//
            return Page();
        }
    }
}
