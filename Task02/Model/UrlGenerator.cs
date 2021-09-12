using System;
using System.Linq;

namespace Task02.Model
{
    public static class UrlGenerator
    {
        private static Random random = new Random();
        
        public static string PayLink(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return "/paylink/" + new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray()); 
        }
    }
}