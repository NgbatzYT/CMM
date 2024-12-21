using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using CMM.Models;

namespace CMM.Pages
{
    public class IndexModel : PageModel
    {
        public List<Mod> Mods { get; private set; } = new List<Mod>();

        public void OnGet()
        {
            // Load mods from JSON file
            var jsonPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "mods.json");
            var jsonData = System.IO.File.ReadAllText(jsonPath);
            Mods = JsonSerializer.Deserialize<List<Mod>>(jsonData) ?? new List<Mod>();
        }
    }
}
