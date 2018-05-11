using EDI.Models.Attributes;

namespace EDI.Models.LoadTender
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
