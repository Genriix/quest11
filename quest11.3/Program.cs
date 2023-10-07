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
        public DateTime DateOfHire
        {
            get { return dateOfHire; }
            set { dateOfHire = value; }
        }

        public Employee(string name, string surname, DateTime dateOfHire)
        {
            Name = name;
            Surname = surname;
            DateOfHire = dateOfHire;
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
            Console.WriteLine(
                $"Имя:                   {Name}\n" +
                $"Фамилия:               {Surname}\n" +
                $"Дата приёма на работу: {DateOfHire.ToShortDateString()}\n" +
                $"Оклад:                 {salary}\n" +
                $"Налоговый сбор:        {salary * 0.34}\n" +
                $"Должность:             {Employee.Position.Boss}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee("Ильин", "Владислав", DateTime.Parse("29.08.2021"));
            double salary = one.Calculation(Employee.Position.Boss);
            one.Show();
            

            Console.ReadKey();
        }
    }
}
