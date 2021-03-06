using Ganss.Excel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace RustaConsumerList.Models
{
    public record ProductImage
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        [ForeignKey("ConsumptionProduct")]
        public double ConProdId { get; set; }
        public ConsumptionProduct ConProd { get; set; }

    }
}
