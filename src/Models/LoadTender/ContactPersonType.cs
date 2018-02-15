using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.LoadTender
{
    /// <summary>
    /// Ref:G6101; Id:366
    /// </summary>
    public enum ContactPersonType
    {
        Unknown,
        [EnumInfo("CN", "General Contact")]
        GeneralContact,
        [EnumInfo("AP", "Accounts Payable Department")]
        AccountsPayableDepartment,
        [EnumInfo("RP", "Responsible Person")]
        ResponsiblePerson,
        [EnumInfo("OB", "Operations")]
        Operations,
        [EnumInfo("DC", "Delivery Contact")]
        DeliveryContact,
        [EnumInfo("SH", "Shipper Contact")]
        ShipperContact,
        [EnumInfo("IC", "Information Contact")]
        InformationContact,
        UnSpecified
    }
}
