using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Views_and_Sessions.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [Display(Name = "What is your name?")]
        public string Name { get; set; }
    }
}