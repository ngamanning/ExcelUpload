using ExcelDataReader;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUpload.Repository
{
    public class FileManagement : IFileManagement
    {
        public async Task UploadExcelFileToServer(IFormFile file)
        {
            if (file == null) return;             
            var stream = file.OpenReadStream();
          
            IExcelDataReader excelReader = ExcelReaderFactory.CreateReader(stream);
            stream.ConfigureAwait(true);
           DataSet result = excelReader.AsDataSet();           
        }
    }
}
