using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUpload.Models
{
    public class FormModel
    {
       [Required]
       [RegularExpression(@"^^.*\.(xlsx|xlsm|xlsb|xls|csv)",
       ErrorMessage = "Only Excel file is allowed")]
       public IFormFile File { get; set; }
    }
}
