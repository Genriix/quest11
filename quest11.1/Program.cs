using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest11._1
{
    class User // Создаём класс User
    {
        public string login; // Объявляем свойство логин
        public string surname; // Объявляем свойство фамилия
        public string password; // Объявляем свойство пароль
        public int age; // Объявляем свойство возраст
        private DateTime date1 = new DateTime(2023, 10, 04);
        public DateTime Date // Объявляем поле Дата
        {
            set { date1 = new DateTime(2023, 10, 04); } // Сохраняем неизменяемое значение (из мэйна) для даты
            get { return date1; }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.login = "Vladislav";
            user.surname = "Il'in";
            user.password = "VBpaQNkJ";
            user.age = 407;
            user.Date = new DateTime(2023, 03, 29);

            Console.WriteLine(user.login + "\n" + user.password + "\n" + user.surname + "\n" + user.age + "\n" + user.Date.ToShortDateString());

            Console.ReadKey();
        }
    }
}
