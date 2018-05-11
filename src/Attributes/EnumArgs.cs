using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Models.Attributes
{
    public class EnumArgs : Attribute
    {
        internal EnumArgs(params string[] args)
        {
            StringArgs = args;
        }
        public string[] StringArgs { get; set; }
    }
}
