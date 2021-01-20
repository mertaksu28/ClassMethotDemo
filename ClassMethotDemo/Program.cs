using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123;
            customer1.Adi = "Mert";
            customer1.SoyAdi = "Aksu";

            Customer customer2 = new Customer();
            customer2.Id = 456;
            customer2.Adi = "Kenan";
            customer2.SoyAdi = "Okay";

            Console.WriteLine("------Eklenen Müşteriler-----");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer1);
            customerManager.Ekle(customer2);

            Customer[] customers = new Customer[] { customer1, customer2 };
            Console.WriteLine("*****Müşteriler******");
            foreach (var c in customers)
            {
                
                Console.WriteLine("Müşteri Id : " + c.Id);
                Console.WriteLine("Müşteri Adi: " +c.Adi);
                Console.WriteLine("Müşteri Soyadi : " +c.SoyAdi);
                Console.WriteLine("------");
            }

            Console.WriteLine("------Silinen Müşteriler-----");

            customerManager.CustomerDel(customer1);
            customerManager.CustomerDel(customer2);




            Console.ReadLine();
        }
    }
}
