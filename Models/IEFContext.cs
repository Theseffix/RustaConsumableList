using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using RustaConsumerList.Models;

namespace RustaConsumerList.Models
{
    public interface IEFContext
    {
        DbSet<ConsumptionProduct> Products { get; set; }
    }
}