using Microsoft.EntityFrameworkCore;

namespace Alphacert.Acc.Ods.Entities
{
    public partial class IDS_ODSContext : DbContext
    {
        public IDS_ODSContext(DbContextOptions<IDS_ODSContext> options) : base(options)
        {

        }

    }

}
