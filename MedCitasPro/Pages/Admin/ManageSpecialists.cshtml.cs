using Microsoft.AspNetCore.Mvc.RazorPages;
using MedCitasPro.Models; // Importamos el espacio de nombres donde está la clase Specialist

namespace MedCitasPro.Pages.Admin
{
    public class ManageSpecialistsModel : PageModel
    {
        public List<Specialist> Specialists { get; set; }

        public void OnGet()
        {
            // Simular especialistas
            Specialists = new List<Specialist>
            {
                new Specialist { Id = 1, Name = "Dr. Juan Pérez", Specialty = "Cardiología", Phone = "123-456-7890", Email = "juan.perez@hospital.com" },
                new Specialist { Id = 2, Name = "Dra. María López", Specialty = "Pediatría", Phone = "987-654-3210", Email = "maria.lopez@hospital.com" }
            };
        }
    }
}
