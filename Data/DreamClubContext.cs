using DreamClub.Models;
using Microsoft.EntityFrameworkCore;

namespace DreamClub.Data
{
    public class DreamClubContext : DbContext
    {
        public DreamClubContext(DbContextOptions<DreamClubContext> options):base(options)
        {

        }

        public virtual DbSet<TrialCustomer> TrialCustomers { get; set; }
    }
}
