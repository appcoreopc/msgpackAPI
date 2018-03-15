using Alphacert.Acc.Ods.Api.Models;
using MessagePack;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Alphacert.Acc.Ods.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:5050")
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/x-msgpack"));

            var result = await client.GetAsync("/ODSData/valuationsdata?version=1&last-modified=1");

            var bytes = await result.Content.ReadAsByteArrayAsync();

            var returnValueType = MessagePackSerializer.Deserialize<IEnumerable<ViewValuation>>(bytes);

            Console.WriteLine($"Bytes size: {bytes.Length}");
            Console.WriteLine(returnValueType.GetType().Name);
            
            foreach (var item in returnValueType)
            {
                Console.WriteLine(item.InstrumentId + ":" + item.GrossMarketValueBase);
                
            }
            

           
        }
    }
}
