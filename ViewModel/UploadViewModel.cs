using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadApiSample.ViewModel
{
    public class UploadViewModel
    {
        public IFormFile File { get; set; }

        public string Value { get; set; }
    }
}
