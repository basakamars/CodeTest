using System;
using Newtonsoft.Json;
namespace Core_Json.net_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestObject o = new TestObject();
            o.ID = 99;
            o.Money = 99.99m;
            o.Name = "Test Object";
            o.Update = DateTime.Now.AddDays(7);
            o.Params.Add("P1", 1);
            o.Params.Add("P2", "String 2");
            o.Params.Add("P3", 101.01m);
            o.Params.Add("P4", DateTime.Now);
            string json = JsonConvert.SerializeObject(o);
            Console.WriteLine(json);
            TestObject p = JsonConvert.DeserializeObject<TestObject>(json);
            Console.WriteLine(p.Params["P4"]);
        }
    }
}
