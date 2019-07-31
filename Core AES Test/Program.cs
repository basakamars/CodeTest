using System;

namespace Core_AES_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine(str);
            AES objHelp = new AES();
            str = objHelp.Encrypt(str);
            Console.WriteLine(str);
            str = objHelp.Decrypt(str);
            Console.WriteLine(str);
        }
    }
}
