using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;



namespace EncryptionExample
{
    public class CipherMain
    {
        public static void Main(string[] args)
        {

            //"a3d70a106f90faa493da549cd3e77a70"
            AESCipher aes = new AESCipher();
            
            string encryptedAesMsg = aes.Encrypt("Top Secret Message " + "\n" + "abcdefghijklmnopqrstuvwxyz padding" + "\n" +"complete sequence" + "\n" +"123664ch19611229310");

            
            Console.WriteLine(encryptedAesMsg);
            Console.WriteLine();
            Console.WriteLine(aes.Decrypt(encryptedAesMsg));
            Console.WriteLine();


            XmlDocument loadkey = new XmlDocument();
            loadkey.Load(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\AESkey.xml");

            AESCipher aesrepeat = new AESCipher();
            XmlNodeList element  = loadkey.SelectNodes("//AESkey");
            string key = element.g
            aesrepeat.Assign(key);

            string repeatedAesMsg = aesrepeat.Encrypt("Top Secret Message " + "\n" + "abcdefghijklmnopqrstuvwxyz padding" + "\n" +"complete sequence" + "\n" +"123664ch19611229310");;

            Console.WriteLine(repeatedAesMsg);
            Console.WriteLine();
            Console.WriteLine(aesrepeat.Decrypt(repeatedAesMsg));
            Console.WriteLine();


            RSACipher rsa = new RSACipher();
            rsa.Assign();
            string encryptedRsaMsg = rsa.Encrypt("Top Secret Message");


            Console.WriteLine(encryptedRsaMsg);
            Console.WriteLine();
            Console.WriteLine(rsa.Decrypt(encryptedRsaMsg));

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
