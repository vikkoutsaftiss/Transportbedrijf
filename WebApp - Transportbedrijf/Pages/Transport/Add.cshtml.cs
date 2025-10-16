using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using WebApp___Transportbedrijf.Models;

namespace WebApp___Transportbedrijf.Pages.Transport
{
    public class AddModel : PageModel
    {
        [Required]
        public TransportModel Transport { get; set; } = new();
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
