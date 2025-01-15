using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedCitasPro.Pages.Admin
{
    public class DeleteUserModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }

        public void OnGet(string email)
        {
            Email = email;
        }

        public IActionResult OnPost()
        {
            // Simular eliminación en la base de datos
            // Implementa aquí la lógica para eliminar el usuario

            return RedirectToPage("/Admin/ManageUsers");
        }
    }
}
