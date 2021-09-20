namespace Henri.Core.Entities
{
    public class ContainerConfig
    {
        public string Hostname {get; set; }
        public string DomainName {get; set; }
        public string User {get; set; }
        public bool AttachStdin {get; set; }
        public bool AttachStdout {get; set; }
        public bool AttachStderr {get; set; }
        public bool Tty {get; set; }
        public bool OpenStdin {get; set; }
        public bool StdinOnce {get; set; }
        public object Env {get; set; }
        public object Cmd {get; set; }
        public string Image {get; set; }
        public object Volumes {get; set; }
        public string WorkingDir {get; set; }
        public object EntryPoint {get; set; }
        public object OnBuild {get; set; }
        public object Labels {get; set; }
    }
}