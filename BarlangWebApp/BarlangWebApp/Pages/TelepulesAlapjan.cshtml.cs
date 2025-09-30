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
    public class TelepulesAlapjanModel : PageModel
    {
        private readonly BarlangWebApp.Data.BarlangDbContext _context;

        public TelepulesAlapjanModel(BarlangWebApp.Data.BarlangDbContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet = true)]
        public string KivalasztottTelepules { get; set; } = default!;

        public IList<string> Telepulesek { get; set; } = default!;
        public IList<Barlang> Barlang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Telepulesek = await _context.barlangok
                .Select(x => x.Telepules)
                .OrderBy(x => x)
                .ToListAsync();

            Barlang = await _context.barlangok
                .Where(x => x.Telepules == KivalasztottTelepules)
                .ToListAsync();
        }
    }
}
