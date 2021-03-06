﻿using EDI.Models.Shared;
using System;

namespace EDI.Models.MethodModels
{
    public abstract class BaseMethodModel
    {
        public Guid TransactionGuid { get; set; } = Guid.NewGuid();
        public Partner Partner { get; set; }
        public string PartnerOrderNumber { get; set; }
        public DateTime CreationDateTime { get; set; } = DateTime.UtcNow;
    }
}
