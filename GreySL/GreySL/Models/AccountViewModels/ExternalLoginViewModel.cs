using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GreySL.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
