using System;
using System.Collections.Generic;
using System.Text;

namespace Core_Json.net_Test
{
    public class TestObject
    {
        public TestObject()
        {
            Params = new Dictionary<string, object>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Money { get; set; }
        public DateTime Update { get; set; }
        public Dictionary<string,object> Params { get; set; }
    }
}
