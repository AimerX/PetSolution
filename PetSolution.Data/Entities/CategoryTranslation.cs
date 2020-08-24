using System;
using System.Collections.Generic;
using System.Text;

namespace PetSolution.Data.Entities
{
   public class CategoryTranslation
    {
        public int Id { set; get; }
        public int CategoryId { set; get; }
        public string Name { set; get; }
        public string SeoDecription { set; get; }
        public string SeoTitle { set; get; }
        public string LanguageId { get; set; }
        public string SeoAlias { get; set; }
    }
}
