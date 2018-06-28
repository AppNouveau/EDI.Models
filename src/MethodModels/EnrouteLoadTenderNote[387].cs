using System;
using System.Collections.Generic;
using System.Text;

namespace EDI.Models.MethodModels
{
    public class EnrouteLoadTenderNote : BaseMethodModel
    {
        public bool IsCritical { get; set; }
        public string Note { get; set; }
    }
}
