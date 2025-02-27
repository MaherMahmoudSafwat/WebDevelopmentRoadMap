using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagers
{
    class EncryptionUtility
    {
        private static readonly string _originalChars = "ABCDEFGHIJKLMNOPQESTYVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly string _altchars = "v7QhW1y3zXoP9bLqgRjUe0dYf5aV2s8I4mN6TJxkiZpctEAHBGFCDOMnwr8S";
        public static string Encrypt(string password)
        {
            var sb = new StringBuilder();
            foreach (var ch in password)
            {
                var CharIndex = _originalChars.IndexOf(ch);
                sb.Append(_altchars[CharIndex]);
            }
            return sb.ToString();
        }
        public static string Decrypt(string password)
        {
            var sb = new StringBuilder();
            foreach(var ch in password)
            {
                var CharIndex = _altchars.IndexOf(ch);
                sb.Append(_originalChars[CharIndex]);
            }
            return sb.ToString();
        }
    }
}
