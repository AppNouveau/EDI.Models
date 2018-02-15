using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.LoadTender
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
