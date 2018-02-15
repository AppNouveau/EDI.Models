using EDI.Library.Models.LoadTender;
using EDI.Library.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Shared
{
    /// <summary>
    /// S5 Pick-Up/Delivery
    /// </summary>
    public class Stop
    {
        public int StopNumber { get; set; }
        public List<ReferenceNumber> ReferenceNumbers { get; set; } //Rename to identification codes/L11
        public List<DateTimeSpecial> DateTimes { get; set; }
        public List<Instruction> Instructions { get; set; } //NTE
        public List<Part> Parts { get; set; }
        public Entity StopEntity { get; set; }
        //AT8
    }
}
