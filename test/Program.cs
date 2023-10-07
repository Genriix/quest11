using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Employee
    {
        DateTime dateOfHire; // Свойство для хранения типа данных время

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Post { get; set; }
        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        } // Поле реализации свойства время

        public Employee(string name, string surname, string post, string set_DateOfHire)
        {
            FirstName = name;
            LastName = surname;
            Post = post;
            dateOfHire = DateTime.Parse(set_DateOfHire);
        }





        double salary;

        public enum Position
        {
            Worker = 10000,
            Manager = 100000,
            Boss = 1000000
        }
        public double DiscoverGrade(DateTime dateOfHire)
        /// метод, который определяет повышающий коэффициент в зависимости от стажа в днях\\\
        {
            double dateValueForGrade = (DateTime.Now - dateOfHire).TotalDays;

            if (dateValueForGrade >= 1825 && dateValueForGrade < 3650) return 1.5;
            else if (dateValueForGrade >= 3650) return 1.25;
            else return 1.0;
        }

        public double Calculation(Position position) // метод, который рассчитывает заработную плату
        {
            double grade = DiscoverGrade(dateOfHire);
            switch (position)
            {
                case Position.Worker:
                    salary = 10000 * grade;
                    return salary;
                case Position.Manager:
                    salary = 100000 * grade;
                    return salary;
                case Position.Boss:
                    salary = 1000000 * grade;
                    return salary;
                default:
                    Console.WriteLine("No such position!");
                    break;

            }
            return 0.0;
        }







        public void Show()
        {
            Console.WriteLine($"" +
                $"Имя:                              {FirstName}\n" +
                $"Фамилия:                          {LastName}\n" +
                $"Должность:                        {Post}\n" +
                $"Дата приёма на текущую должность: {DateOfHire.ToShortDateString()}\n");
        }
    }
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Владислав", "Ильин", "Типа босс", "29.08.2021");
            employee.Show();

            Console.ReadLine();
        }
    }
}
