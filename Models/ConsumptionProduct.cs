using System.Collections.Generic;

namespace RustaConsumerList.Models
{
    public class ConsumptionProduct
    {
        //[Column ("Assortment Node")]
        public double Id { get; set; }
        //[Column ("Assortment Description")]
        public string Name { get; set; }
        //[Column("Category")]
        public string Category { get; set; }
    }
}
