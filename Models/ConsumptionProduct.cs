using Ganss.Excel;
using System.Collections.Generic;
using System.Linq;

namespace RustaConsumerList.Models
{
    public record ConsumptionProduct
    {
        [Column ("Assortment Node")]
        public double Id { get; set; }
        [Column ("Assortment Description")]
        public string Name { get; set; }
        [Column("Category")]
        public string Category { get; set; }
        public int DynamicRow { get; set; }

        public List<ConsumptionProduct> MassImportProducts()
        {
            var products = new ExcelMapper("wwwroot/db.xlsx").Fetch<ConsumptionProduct>();
            return products.Distinct().ToList();
        }



    }
}
