using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class ManageUsersModel : PageModel
    {
        public List<User> Users { get; set; } = new List<User>
        {
            new User { Email = "admin@medcitaspro.com", Role = "Admin" },
            new User { Email = "secretaria@medcitaspro.com", Role = "Secretaria" },
            new User { Email = "paciente@medcitaspro.com", Role = "Paciente" }
        };

        public void OnGet()
        {
            // Aquí puedes cargar los usuarios desde una base de datos en el futuro
        }
    }

    public class User
    {
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
