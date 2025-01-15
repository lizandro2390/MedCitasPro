using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MedCitasPro.Models; // Importamos el espacio de nombres donde está la clase Specialist

namespace MedCitasPro.Pages.Admin
{
    public class AssignScheduleModel : PageModel
    {
        [BindProperty]
        public int SpecialistId { get; set; }

        [BindProperty]
        public string SpecialistName { get; set; }

        [BindProperty]
        public string Days { get; set; }

        [BindProperty]
        public string Hours { get; set; }

        public void OnGet(int id)
        {
            // Simular cargar especialista
            var specialists = new List<Specialist>
            {
                new Specialist { Id = 1, Name = "Dr. Juan Pérez" },
                new Specialist { Id = 2, Name = "Dra. María López" }
            };

            var specialist = specialists.FirstOrDefault(s => s.Id == id);
            if (specialist != null)
            {
                SpecialistId = specialist.Id;
                SpecialistName = specialist.Name;

                // Simular cargar horario actual
                Days = "Lunes a Viernes";
                Hours = "8:00 AM - 5:00 PM";
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Days) || string.IsNullOrEmpty(Hours))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar horario
            TempData["SuccessMessage"] = $"Horario asignado a {SpecialistName} correctamente.";

            // Redirigir al Dashboard
            return RedirectToPage("/Dashboard");
        }
    }
}
