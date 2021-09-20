using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Henri.Core.Entities;
using Newtonsoft.Json;

namespace Henri.Core.Controllers
{
    public class ImageService
    {
        public List<string> GetImageNames()
        {
            string line;
            using (Process process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "C:\\Program Files\\Docker\\Docker\\resources\\docker.exe";
                process.StartInfo.Arguments = "images --format \"{{.ID}}\"";

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true; 

                process.Start();

                line = process.StandardOutput.ReadToEnd();
            }

            return line.Split('\n').Where(n => n.Length > 2).ToList();
        }


        public List<Image> List()
        {
            string line;
            using (Process process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "C:\\Program Files\\Docker\\Docker\\resources\\docker.exe";
                process.StartInfo.Arguments = "images --format \"{{json . }}\"";

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true; 

                process.Start();

                line = process.StandardOutput.ReadToEnd();
            }
            
            JsonSerializerSettings settings = new JsonSerializerSettings();

            return line.Split('\n')
                .Where(n => n.Length > 2)
                .ToList()
                .ConvertAll(c => JsonConvert.DeserializeObject<Image>(c, settings));
        }

        public ImageInfo GetImage(string id)
        {
            string line;
            using (Process process = new Process())
            {
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = "C:\\Program Files\\Docker\\Docker\\resources\\docker.exe";
                process.StartInfo.Arguments = $"image inspect {id}";

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true; 

                process.Start();

                line = process.StandardOutput.ReadToEnd();

                Console.WriteLine(line);
            }

            return JsonConvert.DeserializeObject<List<ImageInfo>>(line)[0];
        }
    }
}