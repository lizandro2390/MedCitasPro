using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class AddSpecialtyModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar la especialidad (luego se conectará a la base de datos)
            TempData["SuccessMessage"] = "Especialidad agregada correctamente.";

            return RedirectToPage("/Admin/ManageSpecialties");
        }
    }
}
