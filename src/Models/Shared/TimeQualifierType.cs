using EDI.Library.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.Models.Shared
{
    /// <summary>
    /// Ref:G6203; Id:176
    /// </summary>
    public enum TimeQualifierType
    {        
        Earliest,     
        Latest,       
        Scheduled,
        NotSpecified
    }
}
