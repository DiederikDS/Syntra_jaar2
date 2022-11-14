using Logic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestTutorial.Data;

namespace Logic
{
    public interface ITokenRepository
    {
        public void CreateToken(string tokenID, bool isActive);

        public void DeleteToken(string tokenID);
        public Token GetToken(string tokenID);

    }
}
