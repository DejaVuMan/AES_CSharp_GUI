using System;
using System.Windows.Forms;
using System.IO; //
using System.Security.Cryptography; // required for AES 256-bit

namespace AES_Fencrypt_GUI
{
    public partial class EncryptWindow : Form
    {
        public string filePath = "";
        static string encryptTest = "C:\\empty.ibm"; // temporary testing file

        static byte[] constKey = sepStore.safeConstKey;
        // call upon class excluded from Version Control - TODO: Secure in SQL DB?

        static byte[] symkey = sepStore.safeSymKey;

        static string filename = "C:\\Users\\szusz\\source\\repos\\AES_Testing\\AES_Testing\\text.ibm";
        // for testing purposes only - TODO: replace with browse filepath

        private Home mainform;
        public EncryptWindow(Home mainform)
        {
            InitializeComponent();
            this.filePath = mainform.textBox1.Text;
            filePath.Remove(2,1);
            // TODO: decrypt based on file path provided
        }

        private void encButton_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(fileOutput.Text); this will include all environment.newlines as well!
            encrypt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        private void encrypt()
        {
            // Encrypt line-by-line until reach EOF
            // keep going until end
            try
            {
                string raw = fileOutput.Text;

                using(AesManaged aes = new AesManaged())
                {
                    byte[] encrypted = Encrypt(raw, symkey);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void decrypt()
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                    // Decrypt the bytes to a string.    
                string decrypted = Decrypt(symkey); // !!!
                fileOutput.Clear();
                fileOutput.AppendText(decrypted);
                    ///* stopgap solution - Theoretical string length limit is 2,147,483,647
                    // not possible due to not single object being allowed > 2GB assuming UTF-16 (2 bytes per character) in .NET
                    // much more realistic limit is 1,073,741,823 on 32-bit machines.
                    // a realistic limit is 50,000,000 characters, or ~ 12,500,000 words, roughly 250 pages. */
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        static byte[] Encrypt(string plainText, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(constKey, IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            (new FileStream(encryptTest, FileMode.Truncate)).Close();
            File.WriteAllBytes(encryptTest, encrypted);
            return File.ReadAllBytes(encryptTest);
        }

        static string Decrypt(byte[] IV)
        {
            string plaintext = null;
            byte[] cipherText = File.ReadAllBytes(encryptTest);
            // Read byte by byte into cipherText
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(constKey, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }
    }
}