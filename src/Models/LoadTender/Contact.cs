using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.LoadTender
{
    /// <summary>
    /// G61
    /// </summary>
    public class Contact
    {
        public string Name { get; set; }
        public ContactPersonType ContactPerson { get; set; }
        public string Details { get; set; }
        public ContactCommunicationType CommunicateBy { get; set; }
    }
}
