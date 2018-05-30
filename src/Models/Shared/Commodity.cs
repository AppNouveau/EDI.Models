using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.Models.Shared
{
    public class Commodity
    {
        public string Description { get; set; }
        public bool Hazmat { get; set; }
        public int UNCode { get; set; }
    }
}
