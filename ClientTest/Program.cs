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
            NetworkTable.SetClientMode();
            NetworkTable.SetIPAddress("localhost");

            NetworkTable.Initialize();

            Thread.Sleep(1000);

            NetworkTable tbl = NetworkTable.GetTable("Test");
            Console.WriteLine(tbl.IsConnected);

            foreach (var connectionInfo in NtCore.GetConnections())
            {
                Console.WriteLine(connectionInfo);
            }

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
