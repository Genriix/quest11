using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest11._4
{
    class Invoice
    {
        private string customer;
        private string provider;
        private string product_name;
        private int product_quantity;
        public int account;
        public double Сost_with_NDS { get { return account + account / 5; } }
        public void Show()
        {
            Console.WriteLine
                (
                $"Заказчик:............{customer}\n" +
                $"Поставщик:...........{provider}\n" +
                $"Название товара:.....{product_name}\n" +
                $"Количество товара:...{product_quantity}\n" +
                $"Сумма без НДС:.......{account}\n" +
                $"Сумма с НДС:.........{Сost_with_NDS}\n"
                );
        }

        public Invoice(string customer, string contractor, int product_quantity, string product_name, int cost_without_nds) 
        {
            this.customer = customer;                 // Заказчик
            this.provider = contractor;             // Подрядчик
            this.product_quantity = product_quantity; // Кол-во товара
            this.product_name = product_name;         // Название товара
            this.account = cost_without_nds; // Стоимость работ без НДС
        }

    }

    internal class Program
    {
        static void Main()
        {
            Invoice invoice1 = new Invoice("Владислав", "Эльмар", 90, "Арбуз (5 кг.)", 12000);
            invoice1.Show();
            Invoice invoice2 = new Invoice("Alin4ik", "Arth3mis", 3, "Шестёрки", 50000);
            invoice2.Show();

            Console.ReadKey();
        }
    }
}
