using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnyPos.Models
{
    public class ProductModel
    {
        public string productId { get; set; }

        public string name { get; set; }
        public decimal? price { get; set; }
        public int? units { get; set; }
        public string picutureUrl { get; set; }
    }
}
