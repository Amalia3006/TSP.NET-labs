using System.Collections.Generic;

namespace ClassLibraryNetCore.Model
{
    public class Order
    {
        public Client Client { get; set; }
        public HashSet<OrderDetails> OrderDetails { get; set; }
    }
}