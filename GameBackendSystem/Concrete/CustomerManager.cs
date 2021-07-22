using GameBackendSystem.Abstract;
using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Concrete
{
    class CustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public CustomerManager()
        {

        }
        public override void SaveUser(Customer customer)
        {
            if (CheckRealPerson(customer))
            {
                Console.WriteLine("Kullanıcı Sisteme kaydedildi");
            }
            else
            {
                Console.WriteLine("Kullanıcı gerçek değil Sisteme kaydedilemedi");
            }
        }

        public override void DeleteUser(Customer customer)
        {
            if (customer.Id > 0) // Customer sisteme önceden kaydedildi ise
            {

                Console.WriteLine(customer.FirstName + " Kullacını silindi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı silinemedi");
            }
        }

        public override void UpdateUser(Customer customer)
        {
            if(customer.Id > 0) // Customer sisteme önceden kaydedildi ise
            {
                customer.FirstName = "can";
                Console.WriteLine("Kullanıcı güncellendi");
            }
            else
            {
                Console.WriteLine("Kullanıcı güncellenmedi");
            }
        }
    }
}
