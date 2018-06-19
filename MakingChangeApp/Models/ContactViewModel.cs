using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MakingChangeApp.Models
{
    public class ContactViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FromName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string FromEmail { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Message")]
        public string Body { get; set; }
    }
}
