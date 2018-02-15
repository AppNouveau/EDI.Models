﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Library.Attributes;

namespace EDI.Library.Models.Shared
{
    /// <summary>
    /// Ref:AT802; Id:188    
    /// </summary>
    public enum WeightUnitType
    {
        Unknown,
        [EnumInfo("L", "Pounds")]
        Pounds,
        [EnumInfo("K", "Kilograms")]
        Kilograms
    }
}
