using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedCitasPro.Models; // Importamos la clase Specialist

namespace MedCitasPro.Pages.Admin
{
    public class EditSpecialistModel : PageModel
    {
        [BindProperty]
        public Specialist Specialist { get; set; } = new Specialist(); // Instancia inicializada

        public void OnGet(int id)
        {
            // Simular cargar especialista
            var specialists = new List<Specialist>
            {
                new Specialist { Id = 1, Name = "Dr. Juan Pérez", Specialty = "Cardiología", Phone = "123-456-7890", Email = "juan.perez@hospital.com" },
                new Specialist { Id = 2, Name = "Dra. María López", Specialty = "Pediatría", Phone = "987-654-3210", Email = "maria.lopez@hospital.com" }
            };

            Specialist = specialists.FirstOrDefault(s => s.Id == id) ?? new Specialist();
        }

        public IActionResult OnPost()
        {
            if (Specialist == null || string.IsNullOrEmpty(Specialist.Name) || string.IsNullOrEmpty(Specialist.Specialty))
            {
                // Validar campos obligatorios
                ModelState.AddModelError(string.Empty, "Todos los campos son obligatorios.");
                return Page();
            }

            // Simular guardar cambios
            TempData["SuccessMessage"] = $"Especialista {Specialist.Name} actualizado correctamente.";
            return RedirectToPage("/Dashboard");
        }
    }
}
