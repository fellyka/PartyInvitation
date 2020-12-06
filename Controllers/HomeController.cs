
using Microsoft.AspNetCore.Mvc;
using PartyInvitation.Models;
using System.Collections.Generic;
using System.Linq;

namespace PartyInvitation.Controllers
{
    public class HomeController : Controller
    {
         private readonly IBookingRepository repo;
        public HomeController(IBookingRepository repo)
        {
            this.repo = repo;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(InviteeResponse inviteeResponse)
        {
            if(ModelState.IsValid)
            {
                InviteeResponse newInvitee = repo.Add(inviteeResponse);
                return View("Thanks", inviteeResponse);
            }

            return View();
            
        }

        public IActionResult ListResponses()
        {
            IEnumerable<InviteeResponse> invitee = repo.GetAllResponses();
            return View(invitee.Where(x => x.WillAttend == true));
        }

    }
}
