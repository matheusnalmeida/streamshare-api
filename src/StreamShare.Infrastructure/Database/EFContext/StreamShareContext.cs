using Microsoft.EntityFrameworkCore;

namespace StreamShare.Infrastructure.Database.EFContext
{
    public class StreamShareContext : DbContext
    {
        public StreamShareContext(DbContextOptions<StreamShareContext> options) : base(options)
        {

        }
    }
}
