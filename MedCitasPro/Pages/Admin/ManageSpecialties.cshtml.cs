using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class ManageSpecialtiesModel : PageModel
    {
        public List<Specialty> Specialties { get; set; }

        public void OnGet()
        {
            // Simular especialidades (m�s adelante conectaremos con la base de datos)
            Specialties = new List<Specialty>
            {
                new Specialty { Id = 1, Name = "Cardiolog�a", Description = "Especialidad del coraz�n." },
                new Specialty { Id = 2, Name = "Pediatr�a", Description = "Especialidad para ni�os." },
                new Specialty { Id = 3, Name = "Dermatolog�a", Description = "Especialidad de la piel." }
            };
        }
    }

    public class Specialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
