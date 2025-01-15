using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class StatisticsModel : PageModel
    {
        public int TotalUsers { get; set; }
        public int TotalAppointments { get; set; }
        public int TotalSpecialties { get; set; }

        public void OnGet()
        {
            // Simular estadísticas (luego se conectará con la base de datos)
            TotalUsers = 25; // Número simulado de usuarios
            TotalAppointments = 42; // Número simulado de citas
            TotalSpecialties = 10; // Número simulado de especialidades
        }
    }
}
