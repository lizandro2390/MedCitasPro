using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages
{
    public class DashboardModel : PageModel
    {
        [BindProperty]
        public string Role { get; set; }


        public IActionResult OnGet()
        {
            // Recuperar el rol del usuario desde la sesi�n
            Role = HttpContext.Session.GetString("UserRole");

            // Si no hay rol en la sesi�n, redirigir al Login
            if (string.IsNullOrEmpty(Role))
            {
                return RedirectToPage("/Login");
            }

            return Page();
        }



    }
}
