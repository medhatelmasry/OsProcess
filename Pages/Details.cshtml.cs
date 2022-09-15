using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace OsPorocess.Pages
{
    public class DetailsModel : PageModel
    {
        public Process SingleProcess { get; set; } = default!;
        public void OnGet(int id)
        {
            //ViewData["P"] = Process.GetProcessById(id);
            SingleProcess = Process.GetProcessById(id);
        }
    }
}
