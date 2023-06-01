using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace hw1215
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User("Pork", "Denis", true),
                new User("Iluminate", "Ilusha", false),
                new User("Drop", "Cinderella", false),
                new User("Rediska", "Kevin", true),
            };

            foreach (var user in users)
            {
                Console.WriteLine($"Привет {user.Name}");

                if(user.IsPremium == false)
                {
                    ShowAds();
                }
            }

            Console.WriteLine();
            Console.WriteLine("end");

            Console.ReadKey();

        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string log, string name, bool IsPrem) 
        {
            Name = name;
            Login = log;
            IsPremium = IsPrem;
        }
    }
}
