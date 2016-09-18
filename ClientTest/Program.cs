using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NetworkTables;

namespace ClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkTable.SetServerMode();

            NetworkTable.AddGlobalConnectionListener(((remote, info, conn) =>
            {
                Console.WriteLine(info.RemoteIp);
                Console.WriteLine(info.RemoteId);
            }), true);

            NetworkTable.Initialize();

            

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
