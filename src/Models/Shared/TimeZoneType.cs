using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Library.Models.Shared
{
    /// <summary>    
    /// </summary>
    public enum TimeZoneType
    {
        Unknown,
        EasternTime,
        CentralTime,
        MountainTime,
        PacificTime,
        AlaskanTime,
        HawaiianTime,
        AtlanticTime,    
        NewfoundlandTime,
        LocalTime,
        CoordinatedUniversalTime //UTC
    }
}
