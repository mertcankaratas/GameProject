using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerCheckService,ICustomerService
    {
        public bool CheckRealPerson(Customer customer)
        {
           if(Convert.ToInt64(customer.NationalitId) % 3 ==0 && customer.FirstName=="Mertcan" && customer.LastName=="Karataş")
            {
                return true;
            }
            return false;
        }

        public virtual void SaveUser(Customer customer)
        {
            

        }

        public virtual void UpdateUser(Customer customer)
        {
            
        }

        public virtual void DeleteUser(Customer customer)
        {
           
        }

      
    }
}
