using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BarlangWebApp.Data;
using BarlangWebApp.Models;

namespace BarlangWebApp.Pages
{
    public class CreateModel : PageModel
    {
        private readonly BarlangWebApp.Data.BarlangDbContext _context;

        public CreateModel(BarlangWebApp.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Barlang Barlang { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.barlangok.Add(Barlang);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
