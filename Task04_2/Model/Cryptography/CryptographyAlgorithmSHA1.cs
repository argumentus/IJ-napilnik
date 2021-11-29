using Task04_2.Interface;

namespace Task04_2.Model.Cryptography
{
    public class CryptographyAlgorithmSHA1 : ICryptographyAlgorithm
    {
        public string Cryptography(string text)
        {
            return Helper.Crypt.SHA1(text);
        }
    }
}