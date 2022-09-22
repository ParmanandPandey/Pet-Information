using Microsoft.EntityFrameworkCore;
using Pet_Information.DataAccess.Entities;

namespace Pet_Information.DataAccess.Context
{
    public class PetDbContext : DbContext
    {
        public PetDbContext(DbContextOptions<PetDbContext> options) : base(options)
        {

        }

        public DbSet<Pet> Pets { get; set; }
    }
}
