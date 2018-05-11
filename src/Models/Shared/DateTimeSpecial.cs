using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{
    public class DateTimeSpecial
    {
        public DateTimeOffset DateTime { get; set; }
        public TimeQualifierType TimeQualifier { get; set; }
        public OffsetType OffsetType { get; set; }
    }
}
