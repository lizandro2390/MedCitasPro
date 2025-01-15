using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class EditPatientModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        public string Email { get; set; }

        public void OnGet(int id)
        {
            // Simular cargar paciente (más adelante conectaremos con la base de datos)
            var patients = new List<Patient>
            {
                new Patient { Id = 1, Name = "Carlos Jiménez", Phone = "123-456-7890", Email = "carlos.jimenez@example.com" },
                new Patient { Id = 2, Name = "Ana Rodríguez", Phone = "987-654-3210", Email = "ana.rodriguez@example.com" }
            };

            var patient = patients.FirstOrDefault(p => p.Id == id);
            if (patient != null)
            {
                Id = patient.Id;
                Name = patient.Name;
                Phone = patient.Phone;
                Email = patient.Email;
            }
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                // Validar campos obligatorios
                return Page();
            }

            // Simular guardar cambios (más adelante conectaremos con la base de datos)
            TempData["SuccessMessage"] = "Paciente actualizado correctamente.";

            return RedirectToPage("/Admin/ManagePatients");
        }
    }
}
