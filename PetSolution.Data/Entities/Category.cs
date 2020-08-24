using PetSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public decimal SortOrder { set; get; }
        public bool isShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
      
    }
}
