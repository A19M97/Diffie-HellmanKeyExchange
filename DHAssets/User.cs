using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DHAssets
{
    public class User
    {
        private long Base;
        private long Q;
        private long RandomNumber;
        private long OtherUserNumber;
        private long Key;

        public User(long _base, long q)
        {
            Base = _base;
            Q = q;
            RandomNumber = ChooseRandomNumber();
        }

        public void KeyExchange(User user)
        {
            throw new NotImplementedException();
        }

        private long ChooseRandomNumber()
        {
            throw new NotImplementedException();
        }
    }
}
