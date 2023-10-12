using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest11._3
{
    public class Employee
    {
        DateTime dateOfHire;
        double salary;

        public enum Position
        {
            Worker = 10000,
            Manager = 100000,
            Boss = 1000000
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Post {  get; set; }
        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public Employee(string name, string surname, string post, string set_DateOfHire)
        {
            Name = name;
            Surname = surname;
            dateOfHire = DateTime.Parse(set_DateOfHire);
            Post = post;
            if (post == "3") { Calculation(Employee.Position.Worker); }
            else if (post == "2") { Calculation(Employee.Position.Manager); }
            else if (post == "1") { Calculation(Employee.Position.Boss); }
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
                    Post = "Worker";
                    return salary;
                case Position.Manager:
                    salary = 100000 * grade;
                    Post = "Manager";
                    return salary;
                case Position.Boss:
                    salary = 1000000 * grade;
                    Post = "Boss";
                    return salary;
                default:
                    Console.WriteLine("No such position!");
                    break;
            }
            return 0.0;
        }
        public void Show()
        {
            Console.WriteLine(
                $"Имя:                   {Name}\n" +
                $"Фамилия:               {Surname}\n" +
                $"Дата приёма на работу: {DateOfHire.ToShortDateString()}\n" +
                $"Оклад:                 {salary}\n" +
                $"Налоговый сбор:        {salary * 0.34}\n" +
                $"Должность:             {Post}\n");
        }
    }
    internal class Program
    {
        static void Main()
        {
            /// Boss = 1 Manager = 2 Worker = 3 
            /// Дата типа "День.Месяц.Год"
            Employee one = new Employee("Ильин", "Владислав", "2", "29.08.2023");
            Employee ded = new Employee("Андрей", "Каличев", "3", "14.02.1998");
            Employee theBestOfTrainer = new Employee("Данил", "Егоров", "1", "01.09.2015");
            one.Show();
            ded.Show();
            theBestOfTrainer.Show();

            new Employee("Имя", "Фамилия", "1", "01.01.2001").Show();

            Console.ReadKey();
        }
    }
}
