using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TimeTableCore.Models
{
    public partial class TimeTable
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Day cannot be left blank")]
        [Range(2, 8, ErrorMessage = "Day must be 2 to 8")]
        public int Day { get; set; }
        public string Time { get; set; }
        public string Week { get; set; }
        public string Subject { get; set; }
        public string Place { get; set; }
    }
}
