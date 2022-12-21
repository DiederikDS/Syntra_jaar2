using Microsoft.EntityFrameworkCore;
using MVC_Klas.Services;

namespace MVC_Klas.Models
{
    public class DierenartsRepository
    {
        private KlasContext _context;

        public DierenartsRepository(KlasContext klasContext)
        {
            _context = klasContext;
        }

        public List<Dierenarts> GetAll()
        {
            return _context.Dierenartsen.ToList(); 
        }

        public Dierenarts GetByNaam(string naam)
        {
            return _context.Dierenartsen.FirstOrDefault(e => e.Naam == naam);
        }

        public void AddDierenarts(Dierenarts dierenarts)
        {
            if (GetByNaam(dierenarts.Naam) == null)
            {
                _context.Dierenartsen.Add(dierenarts);
                _context.SaveChanges();
            }
        }

        public void UpdateDierenarts(Dierenarts dierenarts)
        {
            Dierenarts aantepassen = GetByNaam(dierenarts.Naam);
            if (aantepassen != null)
            {
                aantepassen.Naam = dierenarts.Naam;
                aantepassen.Adres = dierenarts.Adres;
                aantepassen.Gemeente = dierenarts.Gemeente;
                aantepassen.Specialiatie = dierenarts.Specialiatie;
                _context.SaveChanges();
            }
        }

        public void DeleteDierenarts(string naam)
        {
            Dierenarts te_verwijderen = GetByNaam(naam);
            if (te_verwijderen != null)
            {
                _context.Dierenartsen.Remove(te_verwijderen);
                _context.SaveChanges();
            }
        }
    }
}
