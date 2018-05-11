using EDI.Models.LoadTender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Shared
{
    public class Entity
    {
        public EntityType Type { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public Location Location { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
