using System;
using System.Collections.Generic;

#nullable disable

namespace LimeResume.Models
{
    public partial class Company
    {
        public int IdCompany { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
