using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeTableCore.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "PassWord is required.")]
        public string PassWord { get; set; }
    }
}
