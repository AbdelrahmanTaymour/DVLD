using System.IO;
using System;
using System.Security.Cryptography;
using System.Text;

public static class clsSecurityHelper
{
    private const int SaltSize = 16; // Size of the salt in bytes

    public static string Encrypt(string plainText, string key)
    {
        using (var rng = new RNGCryptoServiceProvider())
        {
            // Generate a random salt
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);

            // Combine salt with plain text
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] combined = Combine(salt, plainTextBytes);

            // Perform AES encryption with the combined data
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                using (var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV))
                using (var msEncrypt = new MemoryStream())
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (var swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(combined);
                    csEncrypt.FlushFinalBlock();

                    // Prepend the salt to the encrypted data
                    byte[] encryptedData = msEncrypt.ToArray();
                    byte[] withSalt = Combine(salt, encryptedData);

                    // Return the encrypted data (with salt) as Base64-encoded string
                    return Convert.ToBase64String(withSalt);
                }

                // Prepend the salt to the encrypted data
                //byte[] encryptedData = msEncrypt.ToArray();
                //byte[] withSalt = Combine(salt, encryptedData);

                
            }
        }
    }

    public static string Decrypt(string cipherText, string key)
    {
        // Extract the salt from the encrypted data
        byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
        byte[] salt = new byte[SaltSize];

        if (cipherTextBytes.Length == 0)
        {
            // Handle empty password
            return null;
        }

        Array.Copy(cipherTextBytes, 0, salt, 0, SaltSize);
        byte[] encryptedData = new byte[cipherTextBytes.Length - SaltSize];
        Array.Copy(cipherTextBytes, SaltSize, encryptedData, 0, encryptedData.Length);

        // Perform AES decryption with the extracted data
        using (var aesAlg = Aes.Create())
        {
            aesAlg.Key = Encoding.UTF8.GetBytes(key);
            aesAlg.IV = new byte[aesAlg.BlockSize / 8];

            using (var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV))
            using (var msDecrypt = new MemoryStream(encryptedData))
            using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            using (var srDecrypt = new StreamReader(csDecrypt))
            {
                // Combine the salt with the decrypted data (for verification)
                byte[] combined = Combine(salt, Encoding.UTF8.GetBytes(srDecrypt.ReadToEnd()));

                // Verify if the salt matches the extracted salt (optional security measure)
                if (!IsEqual(salt, combined, SaltSize))
                {
                    throw new CryptographicException("Salt mismatch during decryption!");
                }

                // Extract the actual decrypted data (without salt)
                return Encoding.UTF8.GetString(combined, SaltSize, combined.Length - SaltSize);
            }
        }
    }

    private static byte[] Combine(byte[] data1, byte[] data2)
    {
        var combined = new byte[data1.Length + data2.Length];
        Array.Copy(data1, 0, combined, 0, data1.Length);
        Array.Copy(data2, 0, combined, data1.Length, data2.Length);
        return combined;
    }

    private static bool IsEqual(byte[] data1, byte[] data2, int length)
    {
        if (data1.Length != length || data2.Length != length)
        {
            return false;
        }

        for (int i = 0; i < length; i++)
        {
            if (data1[i] != data2[i])
            {
                return false;
            }
        }

        return true;
    }
}
