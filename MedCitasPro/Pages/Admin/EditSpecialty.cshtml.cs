using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class EditSpecialtyModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        public void OnGet(int id)
        {
            // Simular cargar especialidad (en el futuro conectaremos con la base de datos)
            var specialties = new List<Specialty>
            {
                new Specialty { Id = 1, Name = "Cardiología", Description = "Especialidad del corazón." },
                new Specialty { Id = 2, Name = "Pediatría", Description = "Especialidad para niños." },
                new Specialty { Id = 3, Name = "Dermatología", Description = "Especialidad de la piel." }
            };

            var specialty = specialties.FirstOrDefault(s => s.Id == id);
            if (specialty != null)
            {
                Id = specialty.Id;
                Name = specialty.Name;
                Description = specialty.Description;
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Description))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar cambios (más adelante se conectará con la base de datos)
            TempData["SuccessMessage"] = "Especialidad actualizada correctamente.";

            return RedirectToPage("/Admin/ManageSpecialties");
        }
    }
}
