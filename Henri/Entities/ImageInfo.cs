using System;
using System.Collections.Generic;

namespace Henri.Core.Entities
{
    public class ImageInfo
    {
        public string Id { get; set; }

        public List<string> RepoTags { get; set; }

        public List<string> RepoDigests { get; set; }

        public string Parent { get; set; }

        public string Comment { get; set; }

        public DateTime Created { get; set; }

        public string Container { get; set; }

        public ContainerConfig ContainerConfig { get; set; }

        public string DockerVersion { get; set; }

        public string Author { get; set; }

        public ImageConfig Config { get; set; }

        public string Architecture { get; set; }

        public string Os { get; set; }

        public double Size { get; set; }

        public double VirtualSize { get; set; }

        public GraphDriver GraphDriver { get; set; }

        public RootFS RootFs { get; set; }

        public Dictionary<string, string> Metadata { get; set; }
    }
}