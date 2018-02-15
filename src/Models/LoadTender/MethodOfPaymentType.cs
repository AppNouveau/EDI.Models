using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.LoadTender
{
    /// <summary>
    /// Ref:B206; Id:146
    /// </summary>
    public enum MethodOfPaymentType
    {
        Unknown,
        [EnumInfo("CC", "Collect")]
        Collect,
        [EnumInfo("PP", "Pre-Paid")]
        Prepaid,
        [EnumInfo("TP", "Third-Party")]
        ThirdParty
    }
}
