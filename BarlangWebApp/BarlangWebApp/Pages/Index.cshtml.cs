using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BarlangWebApp.Data;
using BarlangWebApp.Models;

namespace BarlangWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BarlangWebApp.Data.BarlangDbContext _context;

        public IndexModel(BarlangWebApp.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<Barlang> Barlang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Barlang = await _context.barlangok.ToListAsync();
        }
    }
}
