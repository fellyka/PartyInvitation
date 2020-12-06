
using Microsoft.EntityFrameworkCore;

namespace PartyInvitation.Models
{
    public class InvitationDbContext : DbContext
    {
        public InvitationDbContext(DbContextOptions<InvitationDbContext> options) :base(options)
        {
            
        }

        public DbSet<InviteeResponse> MyInvitees{get;set;}
    }
}