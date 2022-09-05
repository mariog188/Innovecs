using System.Collections.Generic;
using System.Xml.Serialization;

namespace Innovecs.API.Model.Request
{
    public class CompanyQuoteRequest
    {
        public string Source { get; set; }

        public string Destination { get; set; }

        [XmlArray("Packages")]
        [XmlArrayItem("Package")]
        public List<string> Packages { get; set; }
    }
}

