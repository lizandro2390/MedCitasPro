using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class AddSpecialistModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Specialty { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Specialty) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                return Page();
            }

            // Simular guardar el especialista (luego conectaremos con la base de datos)
            TempData["SuccessMessage"] = "Especialista agregado correctamente.";

            return RedirectToPage("/Admin/ManageSpecialists");
        }
    }
}
