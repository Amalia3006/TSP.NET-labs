using System.Collections.Generic;

namespace ClassLibraryNetCore.Model
{
    public class Product
    {
       
        public HashSet<OrderDetails> OrderDetails { get; set; }
    }
}