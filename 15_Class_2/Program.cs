namespace _15_Class_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bir kullanıcı kayıt paneli için sınıf ve propertyler tanımlayarak 2 nesne oluşturup bir listeye ekleyiniz.
            //Id,Username,Password,Email

            List<User> users = new List<User>();

            User user = new User();
            Console.WriteLine("Id:");
            user.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Username:");
            user.Username = Console.ReadLine();

            Console.WriteLine("Email:");
            user.Email = Console.ReadLine();

            Console.WriteLine("Password:");
            user.Password = Console.ReadLine();

            users.Add(user);

            User user2 = new User()
            {
                Id = 2,
                Username = "altanemre",
                Email = "altanemre@gmail.com",
                Password = "1"
            };

            users.Add(user2);

        }
    }

    class User
    {
        public int Id;
        public string Username;
        public string Email;
        public string Password;
    }
}
