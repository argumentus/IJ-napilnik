using Task04_2.Interface;

namespace Task04_2.Model.Cryptography
{
    public class CryptographyAlgorithmMD5 : ICryptographyAlgorithm
    {
        public string Cryptography(string text)
        {
            return Helper.Crypt.MD5(text);
        }
    }
}