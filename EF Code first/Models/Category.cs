using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Code_first.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}