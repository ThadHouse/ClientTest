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

            NetworkTable.Initialize();

            RemoteProcedureCall.CreateRpc("Testing", new RpcDefinition(1, "TestRPC"), ((name, bytes, info) =>
            {
                Console.WriteLine(name);
                Console.WriteLine(info.RemoteId);
                Console.WriteLine(info.RemoteIp);
                return new byte[2];
            }));

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
