namespace MVCTutorial.Models
{
    public class DierRepository
    {
        public DierRepository()
        {
            if (Globals._Dieren == null)
            {
                Globals._Dieren = new List<Dier>();
                Dier x = new Dier();
                x.Benaming = "Hamster";
                x.Familie = "Knaagdieren";
                x.Gevaarlijk = false;
                Globals._Dieren.Add(x);
                
                Dier y = new Dier();
                y.Benaming = "Tijger";
                y.Familie = "Katachtige";
                y.Gevaarlijk = true;
                Globals._Dieren.Add(y);

            }
        }

        public List<Dier> GetAll()
        {
            return Globals._Dieren;
        }

        public Dier GetByBenaming(string benaming) { return Globals._Dieren.Find(e => e.Benaming == benaming); }

    }
}
