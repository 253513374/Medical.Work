using Medical.Extensions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Medical
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly IWebHostEnvironment Environment;

        public FilesController(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost("upload")]
        public async Task<ActionResult> Upload(IFormFile file)
        {
            try
            {
                var trustedFileName = $"{Path.GetRandomFileName()}{file.FileName.Substring(file.FileName.Length - 4, 4)}";
                var path = Path.Combine(Environment.WebRootPath, "bloguploads", trustedFileName);//文件保存绝对路径

                var fileName = $"bloguploads/{trustedFileName}";

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                    //   Serilog.Log.Information();
                }

                return new JsonResult(fileName);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private void VerifyPath(string path)
        {
            path = path.SanitizePath();

            if (!string.IsNullOrEmpty(path))
            {
                // var dir = Path.Combine(_storageRoot, path);

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
        }
    }
}