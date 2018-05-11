using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Models.Attributes;

namespace EDI.Models.Shared
{
    public enum CountryCodeType
    {
        Unknown,
        [EnumArgs("US", "USA")]
        US,
        [EnumArgs("CA", "CAN", "Canada")]
        CA,
        [EnumArgs("MX", "MEX", "Mexico")]
        MX        
    }
}
