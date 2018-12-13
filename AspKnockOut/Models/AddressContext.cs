using Microsoft.EntityFrameworkCore;

namespace AspKnockOut.Models
{
    public class AddressContext : DbContext
    {
        public AddressContext(DbContextOptions<AddressContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set;}
    }
}