using System.Text;

namespace PasswordManagers
{
    internal class Program
    {
        private static readonly Dictionary<string, string> _PasswordEntries = new();
        static void Main(string[] args)
        {
            ReadPasswords();
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. List all passwords");
                Console.WriteLine("2. Add/Change password");
                Console.WriteLine("3. Get password");
                Console.WriteLine("4. Delete Password");

                var SelectedOption = Console.ReadLine();
                if (SelectedOption == "1")
                    ListAllPasswords();
                else if (SelectedOption == "2")
                    AddOrChangePassword();
                else if (SelectedOption == "3")
                    GetPassword();
                else if (SelectedOption == "4")
                    DeletePassword();
                else
                    Console.WriteLine("Invalid Option");
            }
        }
        private static void ListAllPasswords()
        {
            foreach (var entry in _PasswordEntries)
                Console.WriteLine($"{entry.Key}={entry.Value}");
        }
        private static void AddOrChangePassword()
        {
            Console.Write("Please enter website/app name: ");
            var appName = Console.ReadLine();
            Console.Write("Please enter your password: ");
            var Password = Console.ReadLine();

            if (_PasswordEntries.ContainsKey(appName))
                _PasswordEntries[appName] = Password;
            else
                _PasswordEntries.Add(appName, Password);
            SavePasswords();
        }
        private static void GetPassword()
        {
            Console.WriteLine("Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_PasswordEntries.ContainsKey(appName))
                Console.WriteLine($"Your password is: {_PasswordEntries[appName]}");
            else
                Console.WriteLine("Password not found.");
        }
        private static void DeletePassword()
        {
            Console.WriteLine("[Please enter website/app name: ");
            var appName = Console.ReadLine();
            if (_PasswordEntries.ContainsKey(appName))
            {
                _PasswordEntries.Remove(appName);
                SavePasswords();
            }
            else
                Console.WriteLine("Password is not found.");

        }
        private static void ReadPasswords()
        {
            if(File.Exists("Passwords.txt"))
            {
                var PasswordLines = File.ReadAllText("Passwords.txt");
                foreach(var line in PasswordLines.Split(Environment.NewLine))
                {
                    if(!string.IsNullOrEmpty(line))
                    {
                        var equalIndex = line.IndexOf('=');
                        var appName = line.Substring(0, equalIndex);
                        var password = line.Substring(equalIndex + 1);
                        _PasswordEntries.Add(appName, EncryptionUtility.Decrypt(password));
                    }
                }
            } 
        }
        private static void SavePasswords()
        {
            var sb = new StringBuilder();
            foreach(var entry in _PasswordEntries)
            {
                sb.AppendLine($"{entry.Key}={EncryptionUtility.Encrypt(entry.Value)}");
            }
            File.WriteAllText("Passwords.txt",sb.ToString());
        }
    }
}
