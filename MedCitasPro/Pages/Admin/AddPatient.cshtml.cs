using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class AddPatientModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar el paciente (luego conectaremos con la base de datos)
            TempData["SuccessMessage"] = "Paciente agregado correctamente.";

            return RedirectToPage("/Admin/ManagePatients");
        }
    }
}
