using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class AddUserModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Role { get; set; }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Role))
            {
                return Page();
            }

            // Aqu� podr�as guardar el usuario en la base de datos PRUEBA PARA GITHUB
            // Redirigir a la p�gina de gesti�n de usuarios
            return RedirectToPage("/Admin/ManageUsers");
        }
    }
}
