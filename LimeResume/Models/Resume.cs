using System;
using System.Collections.Generic;

#nullable disable

namespace LimeResume.Models
{
    public partial class Resume
    {
        public int IdResume { get; set; }
        public string Fio { get; set; }
        public string Education { get; set; }
        public short YearOfStart { get; set; }
        public short YearOfEnd { get; set; }
        public string AboutU { get; set; }
        public string Awards { get; set; }
        public string Skills { get; set; }
        public string Social { get; set; }
    }
}
