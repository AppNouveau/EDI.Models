using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.LoadTender
{
    /// <summary>
    /// Ref:NTE01; Id:363
    /// </summary>
    public enum InstructionReferenceType
    {
        Unknown,
        [EnumInfo("OTH", "Other Instructions", "Other Instructions or Mutually Defined")]
        Other,
        [EnumInfo("ALT", "Alerts")]
        Alert,
        [EnumInfo("CBH", "Monetary Amount Description")]
        MonetaryAmountDescription,
        [EnumInfo("ECM", "Estimate Comment")]
        EstimateComment,
        [EnumInfo("ADD", "Additional Info")]
        AdditionalInfo,
        UnSpecified,
        UnRecognized
    }
}
