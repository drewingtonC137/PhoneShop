using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneShop.Models;

namespace PhoneShop.Pages.Forms
{
    public class CustomPhoneModel : PageModel
    {
        [BindProperty]
        public PhonesModel Phone { get; set; }

        public float PhonePrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PhonePrice = Phone.BasePrice;
            if (Phone.OledPanel) PhonePrice += 100;
            if (Phone.HighRefresh) PhonePrice += 100;
            if (Phone.BatteryUpgrade) PhonePrice += 50;
            if (Phone.MemoryUpgrade) PhonePrice += 150;
            if (Phone.ProModel) PhonePrice += 300;
            Console.WriteLine(PhonePrice);
            return RedirectToPage("/Checkout/Checkout", new {Phone.PhoneName, PhonePrice });
            
        }
    }
}
