using System.Net;

class DnsTestProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine(new string('*', 30));
        var domainEntry = Dns.GetHostEntry("www.contoso.com");
        Console.WriteLine(domainEntry.HostName);
        foreach (var ip in domainEntry.AddressList)
        {
            Console.WriteLine(ip);
        }
        Console.WriteLine(new string('*', 30));
        var domainEntryByAddress = Dns.GetHostEntry("127.0.0.1");
        Console.WriteLine(domainEntryByAddress.HostName);
        foreach (var ip in domainEntryByAddress.AddressList) {
            Console.WriteLine(ip); 
        }
        Console.ReadLine();
    }
}