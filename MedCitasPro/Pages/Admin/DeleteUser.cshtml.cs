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
            // Simular eliminaci�n en la base de datos
            // Implementa aqu� la l�gica para eliminar el usuario

            return RedirectToPage("/Admin/ManageUsers");
        }
    }
}
