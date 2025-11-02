using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Analys
{
    internal class Program
    {
        // Mina egna värden från Thingspeak
        private const string ChannelId = "3134394";
        private const string ReadApiKey = "WWVLB5H7HFBIDR4S";

        static async Task Main(string[] args)
        {
            Console.WriteLine("Analys av bilens data\n");
            Console.WriteLine("Välj tidsperiod:");
            Console.WriteLine("1) Senaste 24 timmarna");
            Console.WriteLine("2) Senaste 100 datapunkterna");
            Console.Write("Ditt val (1/2): ");
            string val = Console.ReadLine();

            string url = "";

            if (val == "1")
            {
                // Hämtar data för senaste 24 timmarna
                url = $"https://api.thingspeak.com/channels/{ChannelId}/feeds.json?api_key={ReadApiKey}&days=1";
            }
            else if (val == "2")
            {
                // Hämtar senaste 100 datapunkterna
                url = $"https://api.thingspeak.com/channels/{ChannelId}/feeds.json?api_key={ReadApiKey}&results=100";
            }
            else
            {
                Console.WriteLine("Fel val, avslutar programmet.");
                return;
            }

            Console.WriteLine("\nHämtar data från ThingSpeak...\n"); 

        } 
    }
}

