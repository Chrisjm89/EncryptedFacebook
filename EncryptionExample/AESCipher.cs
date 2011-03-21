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
    class AESCipher
    {
        private System.Text.UTF8Encoding utf8Encoding = null;
        private AesManaged aes = null;


        public AESCipher()
        
        {
       
            this.utf8Encoding = new System.Text.UTF8Encoding();
            this.aes = new AesManaged();
            this.aes.Mode = CipherMode.CBC;
            this.aes.Padding = PaddingMode.PKCS7;
            this.aes.KeySize = 128;
            this.aes.BlockSize = 128;

            aes.GenerateKey();
            aes.GenerateIV();

            if (File.Exists(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\AESkey.xml") == true)
                File.Delete(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\AESkey.xml");

            //provide AES encryption key params	
            FileStream fs = new FileStream(@"C:\Users\Chris\Documents\Cambridge\Part II Project\Code\Encryption Example\EncryptionExample\AESkey.xml", FileMode.CreateNew, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            string aesKeyXML = byte2Hex(aes.Key);
            sw.Write("<AESkey>"+ aesKeyXML + "</AESkey>");
            sw.Close();
            fs.Close();



        }

        public void Assign(string key)
        {
            if (key == null || key == "")
                throw new ArgumentException("The key is not null.", "key");
            
            this.utf8Encoding = new System.Text.UTF8Encoding();
            this.aes.Key = hex2Byte(key);
        }


        public string Encrypt(string text2Encrypt)
        {
            byte[] cipherBytes = null;
            
            
            ICryptoTransform transform = null;
            if (text2Encrypt == null)
                text2Encrypt = "";
            try
            {
                cipherBytes = new byte[] { };
                transform = this.aes.CreateEncryptor(this.aes.Key, this.aes.IV);
                byte[] plainText = this.utf8Encoding.GetBytes(text2Encrypt);
                cipherBytes = transform.TransformFinalBlock(plainText, 0, plainText.Length);
            }
            catch
            {

                throw new ArgumentException("text is not a valid string!(Encrypt)", "text");
            }

            return Convert.ToBase64String(cipherBytes);
        }

        public string Decrypt(string text2Decrypt)
        {
            byte[] plainText = null;
            ICryptoTransform transform = null;
            if (text2Decrypt == null || text2Decrypt == "")
                throw new ArgumentException("text is not null.");
            try
            {
                plainText = new byte[] { };
                transform = aes.CreateDecryptor(this.aes.Key, this.aes.IV);
                byte[] encryptedValue = Convert.FromBase64String(text2Decrypt);
                plainText = transform.TransformFinalBlock(encryptedValue, 0, encryptedValue.Length);
            }
            catch
            {
                throw new ArgumentException("text is not a valid string!(Decrypt)", "text");
            }

            return this.utf8Encoding.GetString(plainText);
        }

        public byte[] hex2Byte(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                try
                {
                    bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                catch
                {
                    throw new ArgumentException("hex is not a valid hex number!", "hex");
                }
            }
            return bytes;
        }

        public string byte2Hex(byte[] bytes)
        {
            string hex = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    hex += bytes[i].ToString("X2");
                }
            }
            return hex;
        }
    }
}

