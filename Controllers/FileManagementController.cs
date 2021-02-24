using ExcelUpload.Models;
using ExcelUpload.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelUpload.Controllers
{
    public class FileManagementController : Controller
    {
        private IFileManagement _repository;
        private readonly ILogger<FileManagementController> _logger;
        public FileManagementController(ILogger<FileManagementController> logger, IFileManagement fileManagement)
        {
            _logger = logger;
            _repository = fileManagement;
        }
        public IActionResult Index()
        {
            return View(new FormModel());
        }

        public IActionResult UploadExcelToDb(IFormFile file)
        {           
            _repository.UploadExcelFileToServer(file);
            return RedirectToAction(nameof(Index));
        }
    }
}
