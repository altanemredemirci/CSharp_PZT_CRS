namespace _15_Class_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();

            int i = 0;
            while (i<4)
            {
                User user = new User();

                Console.WriteLine("Username:");
                user.Username = Console.ReadLine();
                Console.WriteLine("Email:");
                user.Email = Console.ReadLine();
                Console.WriteLine("Password:");
                user.Password = Console.ReadLine();

                userList.Add(user);

                i++;
            }

            foreach (User item in userList)
            {
                Console.WriteLine(item.Username);
                Console.WriteLine(item.Email);
                Console.WriteLine("**********");
            }
        }
    }

    class User //class'lar default olarak internal alırlar.
    { //DataAccessModifier:private,public,internal
        public string Username; //property'ler default private alırlar.
        public string Email;
        public string Password;
    }
}
