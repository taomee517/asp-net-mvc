using System.Net.Http;

namespace asp_net_mvc.Models
{
    public class OtaFile
    {
        public string OtaFileName { get; set; }
        public string File1Md5 { get; set; }
        public int SensorType { get; set; }
        public string Mark { get; set; }
        
        // public MultipartContent File { get; set; }
    }
}