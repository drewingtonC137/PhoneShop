using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneShop.Models;

namespace PhoneShop.Pages.Forms
{
    public class CustomPhoneModel : PageModel
    {
        [BindProperty]
        public PhonesModel Phone { get; set; }
        public void OnGet()
        {
        }
    }
}
