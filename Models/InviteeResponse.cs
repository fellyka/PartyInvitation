using System.ComponentModel.DataAnnotations;

namespace PartyInvitation.Models
{
  
    public class InviteeResponse
    {
        public int Id{get;set;}

        [Required]
        [MaxLength(50, ErrorMessage = "Name should not contain more than 30 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}