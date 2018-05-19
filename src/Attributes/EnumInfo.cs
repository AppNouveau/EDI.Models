using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDI.Models.Attributes
{
    public class EnumInfo : Attribute
    {
        public EnumInfo(string id, string name = "", string description = "")
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
