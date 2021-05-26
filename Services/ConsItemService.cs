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

        public async Task UpdateItems(ConsumptionProduct p)
        {
            using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Products.SingleOrDefault(x => x.Id == p.Id);
            q1.Name = p.Name;
            q1.Category = p.Category;
            context.Update(q1);
            context.SaveChanges();
        }
        public async Task DeleteItems(ConsumptionProduct p)
        {
            using var context = dbContextFactory.CreateDbContext();
            var q1 = context.Products.SingleOrDefault(x => x.Id == p.Id);
            context.Remove(q1);
            context.SaveChanges();
        }
        public async Task InsertItems(ConsumptionProduct p)
        {
            using var context = dbContextFactory.CreateDbContext();
            context.Add(p);
            context.SaveChanges();
        }

        public async Task<bool> InsertImageToItem(ProductImage Image, double ArtNumber)
        {
            using var context = dbContextFactory.CreateDbContext();
            var product = context.Products.Where(x => x.Id == ArtNumber).Include(t => t.ProductImages).FirstOrDefault();
            product.ProductImages.Add(Image);
            context.Add(Image);

            context.Update(product);

            await context.SaveChangesAsync();
            return true;
        }

    }
}
