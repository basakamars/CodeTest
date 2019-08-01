using System;
using System.Security.Cryptography;
using NETCore.Encrypt;
using NETCore.Encrypt.Extensions;

namespace NETCore.Encryp_Test
{
    public enum RsaSize
    {
        R2048 = 2048,
        R3072 = 3072,
        R4096 = 4096
    }
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine(str);

            Console.WriteLine("RSA__________________________________________________________________");
            var rsaKey = EncryptProvider.CreateRsaKey();    //default is 2048
            var publicKey = rsaKey.PublicKey;
            var privateKey = rsaKey.PrivateKey;
            //var exponent = rsaKey.Exponent;
            //var modulus = rsaKey.Modulus;
            string encrypted = EncryptProvider.RSAEncrypt(publicKey, str);
            Console.WriteLine(encrypted);
            string decrypted = EncryptProvider.RSADecrypt(privateKey, encrypted);
            Console.WriteLine(decrypted);
            //create rsa by private key
            RSA rsa = EncryptProvider.RSAFromString(privateKey);

            

            Console.WriteLine("MD5__________________________________________________________________");
            Console.WriteLine(EncryptProvider.Md5(str));

            Console.WriteLine("SHA1__________________________________________________________________");
            Console.WriteLine(EncryptProvider.Sha1(str));
            Console.WriteLine("SHA256__________________________________________________________________");
            Console.WriteLine(EncryptProvider.Sha256(str));
            Console.WriteLine("SHA384__________________________________________________________________");
            Console.WriteLine(EncryptProvider.Sha384(str));
            Console.WriteLine("SHA512__________________________________________________________________");
            Console.WriteLine(EncryptProvider.Sha512(str));

            string hmackey = "123";
            Console.WriteLine("HMAC-MD5__________________________________________________________________");
            Console.WriteLine(EncryptProvider.HMACMD5(str, hmackey));
            Console.WriteLine("HMAC-SHA1__________________________________________________________________");
            Console.WriteLine(EncryptProvider.HMACSHA1(str, hmackey));
            Console.WriteLine("HMAC-SHA256__________________________________________________________________");
            Console.WriteLine(EncryptProvider.HMACSHA256(str, hmackey));
            Console.WriteLine("HMAC-SHA384__________________________________________________________________");
            Console.WriteLine(EncryptProvider.HMACSHA384(str, hmackey));
            Console.WriteLine("HMAC-SHA512__________________________________________________________________");
            Console.WriteLine(EncryptProvider.HMACSHA512(str, hmackey));

            Console.WriteLine("BASE64__________________________________________________________________");
            encrypted = EncryptProvider.Base64Encrypt(str, System.Text.Encoding.UTF8);
            Console.WriteLine(encrypted);
            decrypted = EncryptProvider.Base64Decrypt(encrypted, System.Text.Encoding.UTF8);
            Console.WriteLine(decrypted);

            var aseKey = EncryptProvider.CreateAesKey();
            var key = aseKey.Key;
            var iv = aseKey.IV;
            Console.WriteLine("AES__________________________________________________________________");
            Console.WriteLine("key:" + key);
            Console.WriteLine("iv:" + iv);
            Console.WriteLine("Not IV");
            encrypted = EncryptProvider.AESEncrypt(str, key);
            Console.WriteLine(encrypted);
            Console.WriteLine(EncryptProvider.AESDecrypt(encrypted, key));
            Console.WriteLine("Have IV");
            encrypted = EncryptProvider.AESEncrypt(str, key,iv);
            Console.WriteLine(encrypted);
            Console.WriteLine(EncryptProvider.AESDecrypt(encrypted, key,iv));

            Console.WriteLine("EncryptExtensions______________________________________________________");
            Console.WriteLine(str.MD5());
            Console.WriteLine(str.SHA1());
            Console.WriteLine(str.SHA256());
            Console.WriteLine(str.SHA384());
            Console.WriteLine(str.SHA512());
            Console.WriteLine(str.HMACMD5(hmackey));
            Console.WriteLine(str.HMACSHA1(hmackey));
            Console.WriteLine(str.HMACSHA256(hmackey));
            Console.WriteLine(str.HMACSHA384(hmackey));
            Console.WriteLine(str.HMACSHA512(hmackey));
        }
    }
}
