using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class DeletePatientModel : PageModel
    {
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

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
            }
        }

        public IActionResult OnPost()
        {
            // Simular eliminar paciente (más adelante conectaremos con la base de datos)
            TempData["SuccessMessage"] = "Paciente eliminado correctamente.";

            return RedirectToPage("/Admin/ManagePatients");
        }
    }
}
