using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class ManageSchedulesModel : PageModel
    {
        [BindProperty]
        public string WorkingDays { get; set; } = "Lunes a Viernes";

        [BindProperty]
        public string WorkingHours { get; set; } = "8:00 AM - 5:00 PM";

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(WorkingDays) || string.IsNullOrEmpty(WorkingHours))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar los horarios
            TempData["SuccessMessage"] = "Horarios actualizados correctamente.";

            // Redirigir al Dashboard
            return RedirectToPage("/Dashboard");
        }

    }
}
