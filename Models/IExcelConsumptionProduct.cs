using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ganss.Excel;

namespace RustaConsumerList.Models
{
    public class IExcelConsumptionProduct
    {
        public List<ConsumptionProduct> MassImportProducts()
        {
            var products = new ExcelMapper("wwwroot/db.xlsx").Fetch<ConsumptionProduct>();
            return products.Distinct().ToList();
        }

    }
}
