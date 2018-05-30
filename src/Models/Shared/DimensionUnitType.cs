using EDI.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.Models.Shared
{
    public enum DimensionUnitType
    {        
        [EnumInfo("I", "Inches")]
        In,
        [EnumInfo("F", "Feet")]
        Ft
    }
}
