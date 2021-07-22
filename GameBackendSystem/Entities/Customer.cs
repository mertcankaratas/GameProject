using GameBackendSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendSystem.Entities
{
   public class Customer
    {
        public int Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }

        public DateTime DateOfBirth{ get; set; }
        public string NationalitId { get; set; }
    }
}
