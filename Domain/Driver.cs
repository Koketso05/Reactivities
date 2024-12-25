using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Driver
    {
         public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MaidenName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IDNumber { get; set; }        
        public string Address { get; set; }
        public string CarRegNumber { get; set; }
        public string LicenceNumber { get; set; }

    }
}