using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages
{
    public class LoginModel : PageModel
    {
        // Simular base de datos de usuarios
        private readonly List<User> _users = new List<User>
        {
            new User { Email = "admin@medcitaspro.com", Password = "Admin123", Role = "Admin" },
            new User { Email = "secretaria@medcitaspro.com", Password = "Secretaria123", Role = "Secretaria" },
            new User { Email = "paciente@medcitaspro.com", Password = "Paciente123", Role = "Paciente" }
        };

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Validar las credenciales del usuario
            var user = _users.FirstOrDefault(u => u.Email == Email && u.Password == Password);

            if (user == null)
            {
                ErrorMessage = "Correo electrónico o contraseña incorrectos.";
                return Page();
            }

            // Guardar el rol del usuario en la sesión
            HttpContext.Session.SetString("UserRole", user.Role);

            // Redirigir al Dashboard
            return RedirectToPage("/Dashboard");
        }


    }

    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
