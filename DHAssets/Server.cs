using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHAssets
{
    public class Server
    {
        private readonly long _alfa;
        private readonly long _q;
        private double _xb;
        private double _ya;
        private double _key;

        public Server(long alfa, long q)
        {
            _alfa = alfa;
            _q = q;
        }

        public double GetKey()
        {
            return _key;
        }

        public void ReceiveFromClient(double ya)
        {
            _xb = ChooseRandomNumber();
            _ya = ya;
            _key = Math.Pow(_ya, _xb) % _q;
        }

        public double sendYb()
        {
            return Math.Pow(_alfa, _xb) % _q;
        }

        private double ChooseRandomNumber()
        {
            var rand = new Random();
            return rand.Next(1000);
        }
    }
}
