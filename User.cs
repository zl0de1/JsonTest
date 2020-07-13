using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTest
{
    public class Response
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_closed { get; set; }
        public bool can_access_closed { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} id:{2}", first_name, last_name, id);
        }
    }

    public class User
    {
        public List<Response> response { get; set; }
    }
}
