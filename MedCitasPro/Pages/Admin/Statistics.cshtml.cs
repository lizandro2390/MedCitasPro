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
            // Simular estad�sticas (luego se conectar� con la base de datos)
            TotalUsers = 25; // N�mero simulado de usuarios
            TotalAppointments = 42; // N�mero simulado de citas
            TotalSpecialties = 10; // N�mero simulado de especialidades
        }
    }
}
