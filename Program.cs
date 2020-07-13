using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("tx.txt");
            Response res = JsonConvert.DeserializeObject<Response>(input);
            Console.WriteLine(res.id + res.last_name);
            string json = File.ReadAllText("tx2.txt");
            Response res2 = JsonConvert.DeserializeObject<Response>(json);
            Console.WriteLine(res2.id + " " + res2.last_name);
            Console.ReadKey();
        }
    }
}
