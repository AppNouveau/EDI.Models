using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Shared
{
    public class DateTimeSpecial
    {
        public DateTime Value { get; set; }
        public TimeQualifierType TimeQualifier { get; set; }
        public TimeZoneType TimeZone { get; set; }
    }
}
