 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp1.Extras
{
    public class Encrypt
    {
        private readonly RandomNumberGenerator _rng = RandomNumberGenerator.Create();
        private const int PBKDF2_SaltSizeBytes = 8;
        private const int PBKDF2_Iterations = 10000;
        public string EncryptData(string input, string keystr)
        {
            string resultStr;
            byte[] result;
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] key = Encoding.UTF8.GetBytes(keystr);
            using (SymmetricAlgorithm algorithm = new AesCryptoServiceProvider())
            {
                byte[] encrypted;
                byte[] salt = new byte[PBKDF2_SaltSizeBytes];
                int maxKeySize = GetLegalKeySizes(algorithm).Max();

                _rng.GetBytes(salt);
                using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(key, salt, PBKDF2_Iterations))
                {
                    algorithm.Key = pbkdf2.GetBytes(maxKeySize);
                }

                using (ICryptoTransform cryptoTransform = algorithm.CreateEncryptor())
                {
                    using (MemoryStream inputStream = new MemoryStream(inputBytes), transformedStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(inputStream, cryptoTransform, CryptoStreamMode.Read))
                        {
                            cryptoStream.CopyTo(transformedStream);
                        }

                        encrypted = transformedStream.ToArray();
                    }
                }

                result = new byte[salt.Length + algorithm.IV.Length + encrypted.Length];
                Buffer.BlockCopy(salt, 0, result, 0, salt.Length);
                Buffer.BlockCopy(algorithm.IV, 0, result, salt.Length, algorithm.IV.Length);
                Buffer.BlockCopy(encrypted, 0, result, salt.Length + algorithm.IV.Length, encrypted.Length);
            }

            return resultStr = Convert.ToBase64String(result);
        }
        private static int[] GetLegalKeySizes(SymmetricAlgorithm algorithm)
        {
            List<int> keySizes = new List<int>();

            foreach (KeySizes ks in algorithm.LegalKeySizes)
            {
                if (ks.MinSize == ks.MaxSize)
                {
                    keySizes.Add(ks.MinSize / 8); // ks.MinSize represents the size in bits, we want the size in bytes.
                }
                else
                {
                    for (int i = ks.MinSize; i <= ks.MaxSize; i += ks.SkipSize)
                    {
                        keySizes.Add(i / 8); // i represents the size in bits, we want the size in bytes.
                    }
                }
            }

            return keySizes.ToArray();
        }
    }
}
