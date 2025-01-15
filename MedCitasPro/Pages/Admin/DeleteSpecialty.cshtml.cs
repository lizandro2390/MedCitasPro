using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class DeleteSpecialtyModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

        public void OnGet(int id)
        {
            // Simular cargar especialidad (en el futuro conectaremos con la base de datos)
            var specialties = new List<Specialty>
            {
                new Specialty { Id = 1, Name = "Cardiolog�a", Description = "Especialidad del coraz�n." },
                new Specialty { Id = 2, Name = "Pediatr�a", Description = "Especialidad para ni�os." },
                new Specialty { Id = 3, Name = "Dermatolog�a", Description = "Especialidad de la piel." }
            };

            var specialty = specialties.FirstOrDefault(s => s.Id == id);
            if (specialty != null)
            {
                Id = specialty.Id;
                Name = specialty.Name;
            }
        }

        public IActionResult OnPost()
        {
            // Simular eliminar especialidad (m�s adelante se conectar� con la base de datos)
            TempData["SuccessMessage"] = "Especialidad eliminada correctamente.";

            return RedirectToPage("/Admin/ManageSpecialties");
        }
    }
}
