using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Shared
{
    public class Location
    {
        public string AddressLine1 { get; set; } = "";
        public string AddressLine2 { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string Zip { get; set; } = "";
        public CountryCodeType CountryCode { get; set; }
        public double Lat { get; set; } //42.239379 //Decimal Degrees (Not DMS)
        public double Lng { get; set; } //-82.968251
    }
}
