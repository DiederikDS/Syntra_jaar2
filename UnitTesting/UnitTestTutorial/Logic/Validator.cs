using Logic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestTutorial.Data;

namespace Logic
{
    public static class Validator
    {
        static TokenRepository_List TokenRepo = new TokenRepository_List();

        public static int HasAccess(string tokenId, Door door)
        {
            Token token = TokenRepo.GetToken(tokenId);

            if (token.Doors.Contains(door) || token.IsActive)
            {
                return 10;
            }
            else if (!token.Doors.Contains(door))
            {
                return 20;
            }
            else if (!token.IsActive)
            {
                return 21;
            }
            else if (token.TokenId == "0")
            {
                return 22;
            }
            else
            {
                return 0;
            }
        }
    }
}
