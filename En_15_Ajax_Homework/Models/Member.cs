using System;
using System.Collections.Generic;

namespace En_15_Ajax_Homework.Models
{
    public partial class Member
    {
        public int MemberId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }
        public string? FileName { get; set; }
        public byte[]? FileData { get; set; }
    }
}
