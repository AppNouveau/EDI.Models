using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Models.Attributes;

namespace EDI.Models.Shared
{
    /// <summary>
    /// Ref:AT801; Id:187
    /// </summary>
    public enum WeightQualifierType
    {
        Unknown,
        [EnumInfo("G", "Gross Weight")]
        Gross,
        [EnumInfo("T", "Tare Weight")]
        Tare
    }
}
