using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDB.Core
{
    public static class MD5
    {
        public static string Create(string input)
        {
            // Use input string to calculate MD5 hash
            using var md5 = System.Security.Cryptography.MD5.Create();
            var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            var hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            var sb = new StringBuilder();
            foreach (var @byte in hashBytes)
            {
                sb.Append(@byte.ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
    }
}
