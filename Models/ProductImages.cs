using Ganss.Excel;
using System.Collections.Generic;
using System.Linq;

namespace RustaConsumerList.Models
{
    public record ProductImages
    {
        public int Id { get; set; }
        public int ConsumptionProductId { get; set; }
        public ConsumptionProduct ConProd { get; set; }
        public byte[] Image { get; set; }

    }
}
