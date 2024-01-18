namespace Drive {
    class Program {
        static void Main(string[] args) {
            List<string> usernames = new List<string>();
            List<string> passwords = new List<string>();

            Console.WriteLine("1. Login");
            Console.WriteLine("2. Signup");
            Console.Write("Enter your choice (1 or 2): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
            case 1:
                Console.Write("Enter username: ");
                string enteredUsername = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string enteredPassword = Console.ReadLine();
                    int index = usernames.IndexOf(enteredUsername);
                    if(passwords[index] == enteredPassword) {
                        System.Console.WriteLine("Login Successful");
                        break;
                    }
                    else {
                        System.Console.WriteLine("Try Again");
                    }
                
                break;
            case 2:
                Console.Write("Enter new username: ");
                string newUsername = Console.ReadLine();
                Console.Write("Enter new password: ");
                string newPassword = Console.ReadLine();
                bool isUsernamePresent = usernames.Contains(newUsername);
                if(!isUsernamePresent) {
                    usernames.Add(newUsername);
                    passwords.Add(newPassword);
                }
                else {
                    System.Console.WriteLine("Username already exist");
                }
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                break;
            }
        }
    }
}