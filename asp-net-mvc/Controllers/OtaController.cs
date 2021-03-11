// 创建人：taomee
// 创建时间：2021/03/15 18:13

using asp_net_mvc.Models;
using log4net;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_mvc.Controllers
{
    
    
    [Route("ota")]
    [ApiController]
    public class OtaController : ControllerBase
    {
        private readonly ILog _logger = LogManager.GetLogger(Startup.LogRepository.Name, typeof(OtaController));  
        
        [HttpGet("test")]
        public string Msg()
        {
            _logger.Info("进入Test");
            return "ota test msg";
        }
        
        [HttpPost("fileUpload")]
        public string FileUpload()
        {
            _logger.Info("fileUpload");
            var fileCount = HttpContext.Request.Form.Files.Count;
            // var fileOtaFileName = file.OtaFileName;
            // var fileFile1Md5 = file.File1Md5;
            // var sensorType= file.SensorType;
            // var mark = file.Mark;
            // var content = file.File;
            return "http://oss.aliyuncs.com/htjc/iot/oiujsloweo.bin";
        }
    }
}