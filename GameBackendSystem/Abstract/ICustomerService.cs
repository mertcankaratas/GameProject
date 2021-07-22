using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Abstract
{
   public interface ICustomerService
    {
        void SaveUser(Customer customer);
        void UpdateUser(Customer customer);
        void DeleteUser(Customer customer);
    }
}
