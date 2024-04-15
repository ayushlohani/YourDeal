using System;
using System.Diagnostics;
using System.Xml.Linq;
using Volo.Abp.Domain.Entities;

namespace TodoApp
{
    public class PropModel : BasicAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Catogary { get; set; } //RESORT/VILLA/FLAT/HOUSE/FARMHOUSE
        public string Status { get; set; } //ONSALE/ONRENT/NOTAVAILABLE
        public string ImageUrl { get; set; }
        public string OwnerName { get; set; }

        public string OwnerPhoneNo { get; set; }
        public int SQFT {  get; set; }
        public  int Price { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public string Description { get; set; }
    }
}
