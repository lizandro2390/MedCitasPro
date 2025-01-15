using Microsoft.AspNetCore.Mvc.RazorPages;
using MedCitasPro.Models; // Importamos el espacio de nombres donde est� la clase Specialist

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
                new Specialist { Id = 1, Name = "Dr. Juan P�rez", Specialty = "Cardiolog�a", Phone = "123-456-7890", Email = "juan.perez@hospital.com" },
                new Specialist { Id = 2, Name = "Dra. Mar�a L�pez", Specialty = "Pediatr�a", Phone = "987-654-3210", Email = "maria.lopez@hospital.com" }
            };
        }
    }
}
