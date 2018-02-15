using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Library.Attributes;

namespace EDI.Library.Models.Shared
{
    /// <summary>
    /// L11 Segment
    /// </summary>
    public class ReferenceNumber
    {
        public ReferenceNumberLabelType Type { get; set; }
        public string Value { get; set; }
    }
}
