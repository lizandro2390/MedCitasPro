using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedCitasPro.Models;

namespace MedCitasPro.Pages.Admin
{
    public class DeleteSpecialistModel : PageModel
    {
        [BindProperty]
        public Specialist Specialist { get; set; }

        public void OnGet(int id)
        {
            // Simular cargar especialista
            var specialists = new List<Specialist>
            {
                new Specialist { Id = 1, Name = "Dr. Juan P�rez", Specialty = "Cardiolog�a", Phone = "123-456-7890", Email = "juan.perez@hospital.com" },
                new Specialist { Id = 2, Name = "Dra. Mar�a L�pez", Specialty = "Pediatr�a", Phone = "987-654-3210", Email = "maria.lopez@hospital.com" }
            };

            Specialist = specialists.FirstOrDefault(s => s.Id == id);
        }

        public IActionResult OnPost()
        {
            // Simular eliminaci�n
            TempData["SuccessMessage"] = $"Especialista {Specialist.Name} eliminado correctamente.";
            return RedirectToPage("/Dashboard");
        }
    }
}
