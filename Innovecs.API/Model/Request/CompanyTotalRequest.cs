using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Innovecs.API.Model.Request
{
    [JsonObject(MemberSerialization.OptIn)]
    public class CompanyTotalRequest
    {
        [JsonProperty(PropertyName = "ContactAddress")]
        public string ContactAddress { get; set; }

        [JsonProperty(PropertyName = "WareHouseAddress")]
        public string WareHouseAddress { get; set; }

        [JsonProperty(PropertyName = "PackageDimensions")]
        public List<Dimension> PackageDimensions { get; set; }
    }
}

