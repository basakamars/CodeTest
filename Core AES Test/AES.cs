using System;
using System.Threading.Tasks;

namespace Core_AES_Test
{
    public class AES
    {
        private string crKey = "123456789012345678901234567890ab";

        public AES()
        {

        }
        public AES(string Key)
        {
            crKey = Key;
        }

        public string Encrypt(string Original)
        {
            byte[] resultArray = EncryptByte(Original);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        private byte[] EncryptByte(string Original)
        {
            Byte[] keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(crKey);
            Byte[] toEncryptArray = System.Text.UTF8Encoding.UTF8.GetBytes(Original);
            System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = System.Security.Cryptography.CipherMode.ECB;
            rDel.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

            System.Security.Cryptography.ICryptoTransform cTransform = rDel.CreateEncryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return resultArray;
        }

        public string Decrypt(string Original)
        {
            Byte[] keyArray = System.Text.UTF8Encoding.UTF8.GetBytes(crKey);
            Byte[] toEncryptArray = Convert.FromBase64String(Original);

            System.Security.Cryptography.RijndaelManaged rDel = new System.Security.Cryptography.RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = System.Security.Cryptography.CipherMode.ECB;
            rDel.Padding = System.Security.Cryptography.PaddingMode.PKCS7;

            System.Security.Cryptography.ICryptoTransform cTransform = rDel.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return System.Text.UTF8Encoding.UTF8.GetString(resultArray);
        }
    }
}