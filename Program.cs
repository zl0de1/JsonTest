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
            string input = File.ReadAllText("tx.txt");  //с response
            User user = JsonConvert.DeserializeObject<User>(input);
            Console.WriteLine(user.response[0]);
            
            string json = File.ReadAllText("tx2.txt");  //без response в начале
            Response res2 = JsonConvert.DeserializeObject<Response>(json);
            Console.WriteLine(res2.ToString());

            Console.ReadKey();

            // Возможно, после ключевого слова response в других ответах будет еще значение count
            // например, в методе getfriend или тп, по этому нам и нужен лист user's
        }
    }
}
