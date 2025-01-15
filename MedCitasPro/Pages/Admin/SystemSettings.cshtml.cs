using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class SystemSettingsModel : PageModel
    {
        [BindProperty]
        public string ClinicName { get; set; } = "Consultorio Médico General";

        [BindProperty]
        public string WorkingHours { get; set; } = "Lunes a Viernes: 8:00 AM - 5:00 PM";

        [BindProperty]
        public string ContactEmail { get; set; } = "contacto@medcitaspro.com";

        public void OnGet()
        {
            // Cargar configuración actual del sistema (simulada)
        }

        public IActionResult OnPost()
        {
            // Aquí puedes guardar la configuración en la base de datos
            TempData["SuccessMessage"] = "Configuración actualizada correctamente.";

            // Redirigir al Dashboard con el rol
            return RedirectToPage("/Dashboard", new { role = "Admin" });
        }


    }
}
