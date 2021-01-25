using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Hasan Ata";
            customer1.Surname = "Arslan";
            customer1.CustomerId = 48;
            customer1.CustomerNumber = 1859;
            customer1.CustomerAccount = "hasan_ata_arslan@mail.com";

            Customer customer2 = new Customer();
            customer2.Name = "Yasin";
            customer2.Surname = "Kara";
            customer2.CustomerId = 75;
            customer2.CustomerNumber = 3685;
            customer2.CustomerAccount = "yasinkara546@mail.com";

            customerManager customerManager = new customerManager();
            customerManager.ChangeSettings(customer1);
            customerManager.CloseAccount(customer1);
            customerManager.DelCustomer(customer1);
            customerManager.ChangeSettings(customer2);
            customerManager.CloseAccount(customer2);
            customerManager.DelCustomer(customer2);

            Console.ReadLine();
        }
    }
}
