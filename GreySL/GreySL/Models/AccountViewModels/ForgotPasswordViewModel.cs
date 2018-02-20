using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreySL.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}