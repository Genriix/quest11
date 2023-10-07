using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest11._2
{        
    class Converter
    {

        readonly double rub; // Свойство только для чтения Рубли
        readonly double usd; // Свойство только для чтения Доллары
        readonly double eur; // Свойство только для чтения Евро
        readonly double gpb; // Свойство только для чтения Фунты
        public double nUsd; // Публичное свойство с плавающей точкой Доллары
        public double nEur; // Публичное свойство с плавающей точкой Евро
        public double nGpb; // Публичное свойство с плавающей точкой Фунты

        public double Rub() { return rub; } // Поле возвращающее Рубли
        public double Usd() { return usd; } // Поле возвращающее Доллары
        public double Eur() { return eur; } // Поле возвращающее Евро
        public double Gpb() { return gpb; } // Поле возвращающее Фунты

        public double MethodUsd() { return Math.Round(rub / usd, 4); } // Поле считающее Доллары
        public double MethodEur() { return Math.Round(rub / eur, 4); } // Поле считающее Евро
        public double MethodGpb() { return Math.Round(rub / gpb, 4); } // Поле считающее Фунты

        public Converter(double usd, double eur, double gpb) // Пользовательский конструктор
        {
            this.usd = usd; 
            this.eur = eur;
            this.gpb = gpb;
            Console.Write("Введить сумму(руб): ");
            rub = Convert.ToDouble(Console.ReadLine());
        }

    }

    class Program
    {
        static void Main()
        {
            Converter money = new Converter(99.46, 104.30, 120.14); // Вызов класса Converter
            Console.WriteLine(
                $"Курсы валют: \n\n" +
                $"" +
                $"Доллар:           {money.Usd()}\n" +
                $"Евро:             {money.Eur()}\n" +
                $"Фунты:            {money.Gpb()}\n\n" +
                $"" +
                $"Введена сумма:    {money.Rub()}\n" +
                $"Долларов США:     {money.MethodUsd()}\n" +
                $"Евро:             {money.MethodEur()}\n" +
                $"Фунты стерлингов: {money.MethodGpb()}\n");

            Console.ReadKey();
        }
    }
}
