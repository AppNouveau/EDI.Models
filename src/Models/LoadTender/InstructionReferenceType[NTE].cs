using EDI.Models.Attributes;

namespace EDI.Models.LoadTender
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
