using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.Entities
{
    public class Contract
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { get; set; }
        public string status { get; set; }
      
    }
}
