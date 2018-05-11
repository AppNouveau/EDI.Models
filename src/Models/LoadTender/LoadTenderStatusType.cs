using EDI.Models.Attributes;

namespace EDI.Models.LoadTender
{
    /// <summary>
    /// Ref:B2A01; Id:23
    /// </summary>
    public enum LoadTenderStatusType
    {
        Unknown,
        [EnumInfo("00", "Original")]
        Original,
        [EnumInfo("01", "Cancellation")]
        Cancellation,
        [EnumInfo("05", "Replace")]
        Replace,
        [EnumInfo("18", "Reissue")]
        Reissue
    }
}
