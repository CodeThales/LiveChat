using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace ThayNailDesign.Models
{
    public class AppUser : IdentityUser
    {
        public List<Message> Messages { get; set; }
    }
}
