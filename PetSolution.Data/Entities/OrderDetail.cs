using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductID { set; get; }
        public int Quanlity { set; get; }
        public decimal Price { set; get; }
    }
}
