using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class EditUserModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Role { get; set; }

        private readonly List<User> _users = new List<User>
        {
            new User { Email = "admin@medcitaspro.com", Role = "Admin" },
            new User { Email = "secretaria@medcitaspro.com", Role = "Secretaria" },
            new User { Email = "paciente@medcitaspro.com", Role = "Paciente" }
        };

        public void OnGet(string email)
        {
            var user = _users.FirstOrDefault(u => u.Email == email);
            if (user != null)
            {
                Email = user.Email;
                Role = user.Role;
            }
        }

        public IActionResult OnPost()
        {
            // Simular guardar cambios en la base de datos
            // Aquí podrías implementar la lógica para actualizar al usuario

            return RedirectToPage("/Admin/ManageUsers");
        }
    }
}
