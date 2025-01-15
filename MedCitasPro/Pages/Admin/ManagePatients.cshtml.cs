using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class ManagePatientsModel : PageModel
    {
        public List<Patient> Patients { get; set; }

        public void OnGet()
        {
            // Simular pacientes (más adelante conectaremos con la base de datos)
            Patients = new List<Patient>
            {
                new Patient { Id = 1, Name = "Carlos Jiménez", Phone = "123-456-7890", Email = "carlos.jimenez@example.com" },
                new Patient { Id = 2, Name = "Ana Rodríguez", Phone = "987-654-3210", Email = "ana.rodriguez@example.com" }
            };
        }
    }

    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
