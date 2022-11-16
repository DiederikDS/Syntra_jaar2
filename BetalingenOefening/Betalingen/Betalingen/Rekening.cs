using System.Diagnostics;

namespace Betalingen
{
    public class Rekening
    {

        private Single _HuidigSaldo = 0;

        public Rekening()
        {
            _HuidigSaldo = 100;
        }

        public Single HuidigSaldo
        {
            get { return _HuidigSaldo; }
            
        }

        public bool Transactie(string SoortTran, Single Bedrag)
        {
            bool result = false;

            switch (SoortTran)
            {
                case "+":
                    _HuidigSaldo += Bedrag;
                    result = true;
                    break;
                case "-":
                  
                    if (_HuidigSaldo > Bedrag)
                    {
                        _HuidigSaldo -= Bedrag;
                        result = true;
                    }
                    else
                    {
                        SaldoOntoerijkendException exception = new SaldoOntoerijkendException();
                        Debug.Write(exception.Message);
                        throw exception;
                    }
                    break;
            }

            return result;
        }
    }
}