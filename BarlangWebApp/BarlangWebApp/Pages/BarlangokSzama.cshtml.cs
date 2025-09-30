using BarlangWebApp.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace BarlangWebApp.Pages
{
    public class BarlangokSzamaModel : PageModel
    {
        private readonly BarlangWebApp.Data.BarlangDbContext _context;

        public BarlangokSzamaModel(BarlangWebApp.Data.BarlangDbContext context)
        {
            _context = context;
        }

        public IList<TelepulesenkentDTO> Barlangokszama { get; set; } = default!;
        public IList<string> Telepulesek { get; set; } = default!;
        public  void OnGet()
        {
            Telepulesek = _context.barlangok.Select(x => x.Telepules).Distinct().ToList();
           
            Barlangokszama = Telepulesek.Select(Telepulesek => new TelepulesenkentDTO
            {
                Telepulesneve = Telepulesek,
                Barlangszam = _context.barlangok.Count(x => x.Telepules == Telepulesek)
            }).ToList();
        }
    }
}
