
using System.Collections.Generic;
using System.Linq;

namespace PartyInvitation.Models
{
    public class SqlInviteeResponse : IBookingRepository
    {
        private readonly InvitationDbContext ctx;
        public SqlInviteeResponse(InvitationDbContext ctx)
        {
           this.ctx = ctx;
        }


        public IEnumerable<InviteeResponse> GetAllResponses()
        {
            return ctx.MyInvitees;
        }
       public InviteeResponse GetResponse(string name)
       {
           return ctx.MyInvitees.Find(name);
       }

       public InviteeResponse Add(InviteeResponse invitee)
       {
           ctx.MyInvitees.Add(invitee);
           ctx.SaveChanges();

           return invitee;
       }

    }
}