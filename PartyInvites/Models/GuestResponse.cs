using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Type your full name, please.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type your e-mail address, please.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Type your correct e-mail address, please.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Type your phone number, please.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Answer if you will come, please.")]
        public bool? WillAttend { get; set; }
    }
}