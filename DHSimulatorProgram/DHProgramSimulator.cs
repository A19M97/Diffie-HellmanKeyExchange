using DHAssets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHSimulatorProgram
{
    class DHProgramSimulator
    {
        static void Main(string[] args)
        {
            var client = new Client(2, 11);
            var server = new Server(2, 11);

            client.KeyExchange(server);

            Console.WriteLine("La chiave del client è: "+client.GetKey());
            Console.WriteLine("La chiave del server è: " + server.GetKey());
            Console.ReadLine();
        }
    }
}
