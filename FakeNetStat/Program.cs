using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakeNetStat
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Program program = new Program();

            //read in the configuration file (contain information on how fakenetstat displays)
            String path = Environment.CurrentDirectory + "\\" + "config.txt";
            
            String[] lines;
            lines = File.ReadAllLines(path);

            Console.WriteLine("");
            Console.WriteLine("Active Connections");
            Console.WriteLine("");

            string ProtoHeader = "Proto";
            string LocalAddressHeader = "Local Address";
            string ForeignAddressHeader = "Foreign Address";
            string StateHeader = "State";

            string smallSpacer = "  ";
            string largeSpacer = "                ";

            string connectionSmallSpacer = "    ";
            string connectionMediumSpacer = "              ";
            string connectionLargeSpacer = "              ";
            
            string Headers = smallSpacer + ProtoHeader + smallSpacer + LocalAddressHeader + largeSpacer + ForeignAddressHeader + largeSpacer + StateHeader;

            //print out initial header information (hardcoded)
            Console.WriteLine(Headers);

            //pause for 5 seconds (mimic the operating system retrieving address data)
            //Thread.Sleep(5000);

            int connectionCount = 5;

            //generate fake Protocols, Local Addresses, Foreign Addresses, State
            List<string> protocolList = program.GenerateProtocols(connectionCount);
            List<string> localAddressList = program.GenerateLocalAddress(connectionCount);
            List<string> foreignAddressList = program.GenerateForeignAddress(connectionCount);
            List<string> stateList = program.GenerateState(connectionCount);

            for(int i = 0; i < connectionCount; i++)
            {
                Thread.Sleep(250);
                Console.WriteLine(smallSpacer + protocolList[i] + connectionSmallSpacer + localAddressList[i] + connectionLargeSpacer + foreignAddressList[i] + connectionMediumSpacer + stateList[i]);
            }

            Console.WriteLine(lines[0]);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public List<string> GenerateProtocols(int protocolCount)
        {
            var protocolList = new List<string>();
            for (int i = 0; i < protocolCount; i++)
            {
                protocolList.Add("TCP");
            }
            return protocolList;
        }

        public List<string> GenerateLocalAddress(int localAddressCount)
        {
            var localAddressList = new List<string>();
            var localAddressIP = GenerateIP();

            for (int i = 0; i < localAddressCount; i++)
            {
                //localAddressList.Add("127.0.0.1:12345");

                localAddressList.Add(localAddressIP);
            }
            return localAddressList;
        }

        public List<string> GenerateForeignAddress(int foreignAddressCount)
        {
 
            var foreignAddressList = new List<string>();
            var foreignAddressIP = GenerateIP();

            for (int i = 0; i < foreignAddressCount; i++)
            {
                //foreignAddressList.Add("192.168.0.0:23456");
                foreignAddressList.Add(foreignAddressIP);
            }
            return foreignAddressList;
        }

        public List<string> GenerateState(int stateCount)
        {
            var stateList = new List<string>();
            for (int i = 0; i < stateCount; i++)
            {
                stateList.Add("LISTENING");
            }
            return stateList;
        }

        public string GenerateIP()
        {     
            return $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
        }

    }
}
