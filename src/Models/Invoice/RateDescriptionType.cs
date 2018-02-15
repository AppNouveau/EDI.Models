using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Invoice
{
    public enum RateDescriptionType
    {
        LineHaul = 'L',
        Accessorial = 'A',
        Flat = 'F',
        Fuel = 'U',
        Tax = 'T'
    };
}
