using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EDI.Library.Models.LoadTenderResponse;
using EDI.Library.Models.LoadTender;
using EDI.Library.Models.Shared;

namespace EDI.Library.MethodModels.Post
{
    //public class PostLoadTenderResponses : BaseMethodModel
    //{
    //    public List<LoadTenderResponse> LoadTenderResponses { get; set; }
    //}

    public class LoadTenderResponse : BaseMethodModel
    {
        public string OrderNumber { get; set; }
        public ReservationStatus ReservationStatus { get; set; }
    }
}
