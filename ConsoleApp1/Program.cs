using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Bai 1");
            String hostName = Dns.GetHostName();
            Console.WriteLine("Ten may: " + hostName);
            IPHostEntry ip = Dns.GetHostEntry(hostName);
            int ipNo = 0;
            foreach (IPAddress ipAdd in ip.AddressList)
                Console.WriteLine("IP thu " + ++ipNo + " la: " + ipAdd.ToString());
            Console.WriteLine();

            //2
            Console.WriteLine("Bai 2");
            Console.WriteLine("Nhap IP hoac ten mien: ");
            string host = Console.ReadLine();
            IPHostEntry domainName = Dns.GetHostEntry(host);
            Console.WriteLine("Ten mien: " + domainName.HostName);
            foreach (string s in domainName.Aliases)
                Console.WriteLine("Bi danh: " + s);
            foreach (IPAddress i in domainName.AddressList)
                Console.WriteLine("IP: " + i);
        }
    }
}
