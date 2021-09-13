using System;
using System.ComponentModel.DataAnnotations;


namespace ThayNailDesign.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string TargetName { get; set; }

        [Required]
        public string Text { get; set; }
        public DateTime Date_time { get; set; }
        public string UserId { get; set; }
        public AppUser App_user { get; set; }

        public string TargetId { get; set; }
        public AppUser TargetUser { get; set; }
    }
}
