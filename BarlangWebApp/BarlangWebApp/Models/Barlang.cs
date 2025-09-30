using System.ComponentModel.DataAnnotations;

namespace BarlangWebApp.Models
{
    public class Barlang
    {
        [Key]
        public int Id { get; set; }
        public string Nev {  get; set; }
        public double  Hossz { get; set; }
        public double Kiterjedes { get; set; }
        public double Melyseg { get ; set; }
        public double Magassag {  get; set; }
        public string Telepules { get; set; }
    }
}
