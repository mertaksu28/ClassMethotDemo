using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethotDemo
{
    class CustomerManager
    {
        public void Ekle(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.Id + " " + customer.Adi + " " + customer.SoyAdi);
        }
        public void CustomerDel(Customer tempCustomer)
        {
           
            Console.WriteLine("Müşteriler silindi." + tempCustomer.Id + " " + tempCustomer.Adi + " " + tempCustomer.SoyAdi );
           
        }


    }
}
