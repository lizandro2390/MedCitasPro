using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class ManageSpecialtiesModel : PageModel
    {
        public List<Specialty> Specialties { get; set; }

        public void OnGet()
        {
            // Simular especialidades (más adelante conectaremos con la base de datos)
            Specialties = new List<Specialty>
            {
                new Specialty { Id = 1, Name = "Cardiología", Description = "Especialidad del corazón." },
                new Specialty { Id = 2, Name = "Pediatría", Description = "Especialidad para niños." },
                new Specialty { Id = 3, Name = "Dermatología", Description = "Especialidad de la piel." }
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
