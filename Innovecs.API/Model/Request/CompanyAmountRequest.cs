using System;
using Newtonsoft.Json;

namespace Innovecs.API.Model.Request
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CompanyAmountRequest
    {
        [JsonProperty(PropertyName = "Consignee")]
        public string Consignee { get; set; }

        [JsonProperty(PropertyName = "Consignor")]
        public string Consignor { get; set; }

        [JsonProperty(PropertyName = "Cartons")]
        public string[] Cartons { get; set; }
    }
}

