using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUpload.Repository
{
    public interface IFileManagement
    {
        public Task UploadExcelFileToServer(IFormFile file);
    }
}
