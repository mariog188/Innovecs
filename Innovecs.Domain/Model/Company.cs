using System.Collections.Generic;

namespace Innovecs.Domain.Model
{
    public class Company
    {
        public string SourceAddress { get; set; }

        public string DestinationAddress { get; set; }

        public string ContactAddress { get; set; }

        public string WareHouseAddress { get; set; }

        public string Consignee { get; set; }

        public string Consignor { get; set; }

        public List<Carton> Cartons { get; set; }

        public List<Package> Packages { get; set; }

        public double Amount { get; set; }

        public double Price { get; set; }
    }
}

