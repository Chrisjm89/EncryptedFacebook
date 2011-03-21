using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Collections;
using System.Xml;

namespace EncryptionExample
{
    class RSACipher
    {
        public static RSACryptoServiceProvider RSA = null;
      

        public void Assign()
        {

            // AssignParameter();
            RSA = new RSACryptoServiceProvider(1024);

            if (File.Exists(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\privatekey.xml") == true)
                File.Delete(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\privatekey.xml");
            if (File.Exists(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\publickey.xml") == true)
                File.Delete(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\publickey.xml");

            //provide public and private RSA params	
            FileStream fs = new FileStream(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\privatekey.xml", FileMode.CreateNew, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            string publicPrivateKeyXML = RSA.ToXmlString(true);
            sw.Write(publicPrivateKeyXML);
            sw.Close();
            fs.Close();


            FileStream fs2 = new FileStream(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\publickey.xml", FileMode.CreateNew, FileAccess.ReadWrite);
            StreamWriter sw2 = new StreamWriter(fs2);
            string publicOnlyKeyXML = RSA.ToXmlString(false);
            sw2.Write(publicOnlyKeyXML);
            sw2.Close();
            fs2.Close();



        }




        public string Encrypt(string text2Encrypt)
        {
        
            try
            {
                StreamReader reader = new StreamReader(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\publickey.xml");
                string publicOnlyKeyXML = reader.ReadToEnd();
                RSA.FromXmlString(publicOnlyKeyXML);
                reader.Close();
            }
            catch
            {
                Console.Write("File not found"); 
            }
            //read plaintext, encrypt it to ciphertext
            int keySize = RSA.KeySize / 8;
            byte[] plainbytes = System.Text.Encoding.UTF8.GetBytes(text2Encrypt);

            int maxLength = keySize - 42;
            int dataLength = plainbytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength :
                                              dataLength - maxLength * i];
                Buffer.BlockCopy(plainbytes, maxLength * i, tempBytes, 0, tempBytes.Length);

                byte[] cipherbytes = RSA.Encrypt(plainbytes, true);
                stringBuilder.Append( Convert.ToBase64String(cipherbytes) );
            }
            return stringBuilder.ToString();
        }

        
        public string Decrypt(string text2Decrypt)
        {

            byte[] getpassword = Convert.FromBase64String(text2Decrypt);

           try
            {

            StreamReader reader = new StreamReader(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\privatekey.xml");
            string publicPrivateKeyXML = reader.ReadToEnd();
            RSA.FromXmlString(publicPrivateKeyXML);
            reader.Close();
            }
           catch
           {
                Console.Write("File not found"); 
           }
            int base64BlockSize = ( ( RSA.KeySize / 8 ) % 3 != 0 ) ?
                                  ( ( ( RSA.KeySize / 8 ) / 3 ) * 4 ) + 4 : 
                                  ( ( RSA.KeySize / 8 ) / 3 ) * 4;
            
            int iterations = text2Decrypt.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(text2Decrypt.Substring(base64BlockSize * i, base64BlockSize));

                //read ciphertext, decrypt it to plaintext
                arrayList.AddRange(RSA.Decrypt(getpassword, true));
            }
            return System.Text.Encoding.UTF8.GetString(arrayList.ToArray(
                              Type.GetType("System.Byte")) as byte[]);

        }
    }
}
