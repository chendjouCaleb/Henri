using System.Collections.Generic;

namespace Henri.Core.Entities
{
    public class ImageConfig
    {
        public string Hostname { get; set; }

        public string DomainName { get; set; }

        public string User { get; set; }

        public bool AttachStdin { get; set; }

        public bool AttachStdout { get; set; }

        public bool AttachStderr { get; set; }

        public Dictionary<string, object> ExposedPorts { get; set; }

        public bool Tty { get; set; }

        public bool OpenStdin { get; set; }

        public bool StdinOnce { get; set; }

        public List<string> Env { get; set; }

        public object Cmd { get; set; }

        public string Image { get; set; }

        public object Volumes { get; set; }

        public string WorkingDir { get; set; }

        public List<string> Entrypoint { get; set; }

        public object OnBuild { get; set; }

        public object Labels { get; set; }
        
        
        
    }
}