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
            TempData["SuccessMessage"] = "Horarios actualizados correctamente.";

            // Aquí podrías guardar el usuario en la base de dat
            // Redirigir a la página de gestión de usuarios
            return RedirectToPage("/Admin/ManageUsers");
        }
    }
}
