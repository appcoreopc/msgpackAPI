using Microsoft.EntityFrameworkCore;
using Alphacert.Acc.Ods.Entities.Views;

namespace Alphacert.Acc.Ods.Entities.Entities
{
    public partial class IDS_ODSContext : DbContext
    {
        public virtual DbSet<VwValuations> VwValuations { get; set; }

        public IDS_ODSContext(DbContextOptions<IDS_ODSContext> options) : base(options)
        {

        }
      
    } 
}
