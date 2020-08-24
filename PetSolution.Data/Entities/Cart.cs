using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quanlity { set; get; }
        public decimal Price { set; get; }
    }
}
