using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUploadApiSample.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FileUploadApiSample.Controllers
{
    [ApiController]
    public class UploadController : Controller
    {
        [HttpPost]
        [Route("api/upload")]
        public IActionResult Upload([FromForm] UploadViewModel vm)
        {
            return Ok(new { vm.File.FileName, vm.File.Length});
        }
    }
}
