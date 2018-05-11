using EDI.Models.Attributes;

namespace EDI.Models.LoadTender
{
    /// <summary>
    /// Ref:G6103; Id:365
    /// </summary>
    public enum ContactCommunicationType
    {
        Unknown,
        [EnumInfo("TE", "Phone")]
        Telephone,
        [EnumInfo("FX", "Fax")]
        Fax,
        [EnumInfo("EM", "E-Mail")]
        EMail,
        [EnumInfo("AP", "Alternate Phone")]
        AlternatePhone,
    }
}
