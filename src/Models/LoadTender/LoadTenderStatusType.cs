using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.LoadTender
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
