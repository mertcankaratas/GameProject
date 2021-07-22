using GameBackendSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Abstract
{
   public interface ICustomerCheckService
    {
        bool CheckRealPerson(Customer customer);
    }
}
