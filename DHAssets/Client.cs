using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DHAssets
{
    public class Client
    {
        private readonly long _alfa;
        private readonly long _q;
        private double _xa;
        private double _yb;
        private double _key;

        public Client(long alfa, long q)
        {
            _alfa = alfa;
            _q = q;
        }

        public double GetKey()
        {
            return _key;
        }

        public void KeyExchange(Server server)
        {
            _xa = ChooseRandomNumber();
            var intermediateValue = CalculateIntermediateValue();
            server.ReceiveFromClient(intermediateValue);
            _yb = server.sendYb();
            _key = Math.Pow(_yb, _xa) % _q;

            double CalculateIntermediateValue() => Math.Pow(_alfa, _xa) % _q;

            double ChooseRandomNumber()
            {
                var rand = new Random();
                return rand.Next(1000);
            }
        }

    }
}
