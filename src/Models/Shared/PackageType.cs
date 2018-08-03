using EDI.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.Models.Shared
{
    public enum PackageType
    {
        UnSpecified,
        Bin,
        Box,
        Drum,
        Pallet,
        Rack,
        Roll,
        ToteBin,
        Container,
        Loose,
        Bundle,
        Pieces,
        Crate
    }
}
