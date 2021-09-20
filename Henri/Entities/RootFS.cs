using System.Collections.Generic;

namespace Henri.Core.Entities
{
    public class RootFS
    {
        public string Type { get; set; }

        public List<string> Layers { get; set; }
    }
}