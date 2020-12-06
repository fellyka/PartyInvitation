using System.Collections.Generic;


namespace PartyInvitation.Models
{
    public interface IBookingRepository
    {
        public IEnumerable<InviteeResponse> GetAllResponses();
        
         InviteeResponse GetResponse(string name);
         InviteeResponse Add(InviteeResponse invitee);
    }
}