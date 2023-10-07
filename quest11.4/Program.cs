using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest11._4
{
    class Invoice
    {
        string customer;
        string contractor;
        string product_name;
        int product_quantity;
        int cost_without_nds;

        public string Customer
        { get { return customer; } set { customer = value; } }

        public string Contractor
        { get { return contractor; } set { contractor = value; } }

        public string Product_name
        { get { return product_name; } set { product_name = value; } }

        public int Product_quantity
        { get { return product_quantity; } set { product_quantity = value; } }

        public int Cost_without_NDS
        { get { return cost_without_nds; } set { cost_without_nds = value; } }

        public double Сost_with_NDS { get { return cost_without_nds + cost_without_nds / 5; } }
        public void Show()
        {
            Console.WriteLine
                (
                $"Заказчик:............{Customer}\n" +
                $"Поставщик:...........{Contractor}\n" +
                $"Название товара:.....{Product_name}\n" +
                $"Количество товара:...{Product_quantity}\n" +
                $"Сумма без НДС:.......{Cost_without_NDS}\n" +
                $"Сумма с НДС:.........{Сost_with_NDS}\n"
                );
        }

        public Invoice(string customer, string contractor, int product_quantity, string product_name, int cost_without_nds) 
        {
            this.customer = customer;                 // Заказчик
            this.contractor = contractor;             // Подрядчик
            this.product_quantity = product_quantity; // Кол-во товара
            this.product_name = product_name;         // Название товара
            this.cost_without_nds = cost_without_nds; // Стоимость работ без НДС
        }

    }

    internal class Program
    {
        static void Main()
        {
            Invoice invoice1 = new Invoice("Владислав", "Эльмар", 90, "Арбуз (5 кг.)", 12000);
            invoice1.Cost_without_NDS = 12500;
            invoice1.Show();
            Invoice invoice2 = new Invoice("Alin4ik", "Arth3mis", 3, "Шестёрки", 50000);
            invoice2.Show();

            Console.ReadKey();
        }
    }
}
