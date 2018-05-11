using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.LoadTender
{
    /// <summary>
    /// NTE
    /// </summary>
    public class Instruction
    {        
        public InstructionReferenceType Type { get; set; }        
        public string Value { get; set; }
    }
}
