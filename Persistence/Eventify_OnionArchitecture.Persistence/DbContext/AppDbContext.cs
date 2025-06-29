using Eventify_OnionArchitecture.Domain.Common;
using Eventify_OnionArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eventify_OnionArchitecture.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("EventifyDb");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //deyisdrilmis datalari getiririk...
            var data = ChangeTracker.Entries<EntityBase>();

            //burda hemin entitilerde 1-1 deyisiklikler yoxlanilir ve lazimi kod bloku ise dusur. 
            foreach (var entry in data)
            {
                if (entry.State == EntityState.Added)
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                else if (entry.State == EntityState.Modified)
                    entry.Entity.UpdatedDate = DateTime.UtcNow;
            }


            //Yuxarda geden Proseslere Interception Deyirik! SaveChanges ise dusmeden once araya giren proseslerdir...

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
