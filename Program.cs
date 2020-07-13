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
            User res = JsonConvert.DeserializeObject<User>(input);
            Console.WriteLine(res.response[0].id + res.response[0].last_name);
            
            string json = File.ReadAllText("tx2.txt");
            Response res2 = JsonConvert.DeserializeObject<Response>(json);
            Console.WriteLine(res2.id + " " + res2.last_name);
            Console.ReadKey();
        }
    }
}
