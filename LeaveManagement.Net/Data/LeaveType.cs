﻿namespace LeaveManagement.Net.Data
{
    public class LeaveType : BaseEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
