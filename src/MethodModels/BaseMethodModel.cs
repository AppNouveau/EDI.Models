using EDI.Library.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.MethodModels
{
    public abstract class BaseMethodModel
    {
        public Guid TransactionGuid { get; set; } = Guid.NewGuid();
        public Partner EDIPartner { get; set; }
        public string PartnerOrderNumber { get; set; }
    }
}
