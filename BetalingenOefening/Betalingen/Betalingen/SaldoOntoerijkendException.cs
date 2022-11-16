using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betalingen
{
    public class SaldoOntoerijkendException : Exception
    {
        public SaldoOntoerijkendException() : base("Saldo is ontoerijkend: Te veralgen > _HuidigSaldo")
        {

        }
    }
}
