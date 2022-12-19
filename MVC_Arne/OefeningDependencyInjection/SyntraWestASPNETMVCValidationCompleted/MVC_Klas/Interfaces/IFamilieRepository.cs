using MVC_Klas.Models;

namespace MVC_Klas.Interfaces
{
    public interface IFamilieRepository
    {
        public List<Familie> GetAll();
        public Familie GetByNaam(string naam);
        public bool AddFamilie(Familie familie);
        public void UpdateFamilie(Familie familie);
        public void DeleteFamilie(string naam);

    }
}
