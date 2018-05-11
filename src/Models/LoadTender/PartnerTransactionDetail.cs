using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDI.Models.LoadTender
{
    public class PartnerTransactionDetail
    {
        public string ControlNumber { get; set; } //ST*02
        public string GroupControlNumber { get; set; } //GS*06
    }
}
