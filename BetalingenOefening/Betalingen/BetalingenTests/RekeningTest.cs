using Betalingen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetalingenTests
{
    [TestClass]
    public class RekeningTest
    {
        [TestMethod]
        public void Transactie_BedragVerhogen()
        {
            //Prepare
            Betalingen.Rekening account = new Betalingen.Rekening();
            Single TeVerhogen = 15;
            Single HuidigSaldo = account.HuidigSaldo;

            //Act
            account.Transactie("+", TeVerhogen);

            //Assert
            Assert.AreEqual(HuidigSaldo + TeVerhogen, account.HuidigSaldo);
        }

        [TestMethod]
        public void Transactie_BedragVerlagen()
        {
            //Prepare
            Betalingen.Rekening account = new Betalingen.Rekening();
            Single TeVerlagen = 15;
            Single HuidigSaldo = account.HuidigSaldo;

            //Act
            account.Transactie("-", TeVerlagen);

            //Assert
            Assert.AreEqual(HuidigSaldo - TeVerlagen, account.HuidigSaldo);
        }

        [TestMethod]
        public void Transactie_BedragVerlagenFails()
        {
            //Prepare
            Betalingen.Rekening account = new Betalingen.Rekening();
            Single TeVerlagen = 115;
            Single HuidigSaldo = account.HuidigSaldo;

            //Act

            //Assert
            Assert.ThrowsException<SaldoOntoerijkendException>(() => account.Transactie("-", TeVerlagen));
            
        }
    }
}
