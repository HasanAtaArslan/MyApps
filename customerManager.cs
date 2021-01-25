using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class customerManager
    {
       
        public void DelCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerId + "Id' li kullanıcı silindi.");
        }
        public void ChangeSettings(Customer customer)
        {
            Console.WriteLine(customer.CustomerNumber + " numaralı müşterinin ayarları değitirildi.");
        }
        public void CloseAccount(Customer customer)
        {
            Console.WriteLine(customer.CustomerAccount + " adlı hesap güvenlik sebebiyle kapatıldı.");
        }
    }
}
