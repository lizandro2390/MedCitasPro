using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class ManageSpecialistsModel : PageModel
    {
        public List<Specialist> Specialists { get; set; }

        public void OnGet()
        {
            // Simular especialistas (m�s adelante conectaremos con la base de datos)
            Specialists = new List<Specialist>
            {
                new Specialist { Id = 1, Name = "Dr. Juan P�rez", Specialty = "Cardiolog�a", Phone = "123-456-7890", Email = "juan.perez@hospital.com" },
                new Specialist { Id = 2, Name = "Dra. Mar�a L�pez", Specialty = "Pediatr�a", Phone = "987-654-3210", Email = "maria.lopez@hospital.com" }
            };
        }
    }

    public class Specialist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
