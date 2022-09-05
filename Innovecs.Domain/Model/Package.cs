using System;
namespace Innovecs.Domain.Model
{
    public class Package
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Dimension Dimension { get; set; }
    }
}

