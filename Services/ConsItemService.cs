using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RustaConsumerList.Models;
using Microsoft.EntityFrameworkCore;

namespace RustaConsumerList.Services
{
    public class ConsItemService : Service<ConsumptionProduct>
    {
        private IDbContextFactory<EFContext> dbContextFactory;
        public ConsItemService(IDbContextFactory<EFContext> dbContextFactory) : base(dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public async Task<List<ConsumptionProduct>> GetItems()
        {
            using var context = dbContextFactory.CreateDbContext();
            var AllItems = await context.Products.ToListAsync();

            return AllItems.ToList();
        }

    }
}
