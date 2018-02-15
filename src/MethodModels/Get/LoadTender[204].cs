using EDI.Library.Models.LoadTender;
using EDI.Library.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Library.MethodModels.Get
{
    //public class GetLoadTender : BaseMethodModel
    //{
    //    public List<LoadTender> LoadTenders { get; set; }
    //}

    public class LoadTender : BaseMethodModel
    {
        //HEADER - VALIDATED           
        public PartnerTransactionDetail PartnerTransactionDetail { get; set; }

        public MethodOfPaymentType MethodOfPayment { get; set; }
        public LoadTenderStatusType LoadTenderStatus { get; set; }
        public List<ReferenceNumber> ReferenceNumbers { get; set; } //Rename to identification codes/L11
        public DateTimeSpecial MustRespondByDateTime { get; set; } //G62*64[01]
        public List<Instruction> Instructions { get; set; } //NTE/Notes
        public List<Entity> BuisnessEntities { get; set; } //BillTO Responsible RemitTo
        public List<Stop> Stops { get; set; }
        public Part TotalParts { get; set; }
    }
}
