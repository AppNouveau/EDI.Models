using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Invoice
{
    public enum ChargeDescriptionType
    {
        Linehaul,
        Flat,
        Fuel,
        Accessorial,
        StopOff,
        Layover,
        Border,
        DryRun,
        WaitingTime,
        Equipment,
        Miscellaneous,
    }
}
