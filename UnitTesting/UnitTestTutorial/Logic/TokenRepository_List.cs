using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestTutorial.Data;

namespace Logic.Data
{
    internal class TokenRepository_List : ITokenRepository
    {
        private readonly List<Token> _tokens;

        public TokenRepository_List()
        {
            _tokens = new List<Token>();

            Door door1 = new Door(1);
            Door door2 = new Door(24);
            Door door3 = new Door(54);

            CreateToken("B59D", true);
            GetToken("B59D").AddDoor(door3);
            CreateToken("5789", true);
            GetToken("5789").AddDoor(door2);
            GetToken("5789").AddDoor(door3);
            CreateToken("ABCD", false);
            GetToken("ABCD").AddDoor(door1);
            GetToken("ABCD").AddDoor(door2);
            CreateToken("0", false);
        }

        public void CreateToken(string tokenID, bool isActive)
        {
            Token token = new Token();
            token.TokenId = tokenID;
            token.IsActive = isActive;
            _tokens.Add(token);
        }

        public void DeleteToken(string tokenID)
        {
            _tokens.Remove(_tokens.First(t => t.TokenId == tokenID));
        }

        public Token GetToken(string tokenID)
        {
            foreach(Token token in _tokens)
            {
                if(token.TokenId == tokenID)
                {
                    return token;
                }
            }
            
            return _tokens.FirstOrDefault(t => t.TokenId == "0");
        }
    }
}
