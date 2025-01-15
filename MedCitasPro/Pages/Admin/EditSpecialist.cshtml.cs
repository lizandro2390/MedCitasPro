using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class EditSpecialistModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Specialty { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public void OnGet(int id)
        {
            // Simular cargar especialista (m�s adelante conectaremos con la base de datos)
            var specialists = new List<Specialist>
            {
                new Specialist { Id = 1, Name = "Dr. Juan P�rez", Specialty = "Cardiolog�a", Phone = "123-456-7890", Email = "juan.perez@hospital.com" },
                new Specialist { Id = 2, Name = "Dra. Mar�a L�pez", Specialty = "Pediatr�a", Phone = "987-654-3210", Email = "maria.lopez@hospital.com" }
            };

            var specialist = specialists.FirstOrDefault(s => s.Id == id);
            if (specialist != null)
            {
                Id = specialist.Id;
                Name = specialist.Name;
                Specialty = specialist.Specialty;
                Phone = specialist.Phone;
                Email = specialist.Email;
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Specialty) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar cambios (m�s adelante se conectar� a la base de datos)
            TempData["SuccessMessage"] = "Especialista actualizado correctamente.";

            return RedirectToPage("/Admin/ManageSpecialists");
        }
    }
}
