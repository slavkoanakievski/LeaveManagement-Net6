﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Net.Models
{
    public class LeaveTypeVM
    {
        
        public int Id { get; set; }
        [Display(Name = "Leave Type Name")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Default Number Of Days")]
        [Required]
        [Range(1, 25)]
        public int DefaultDays { get; set; }
    }
}
