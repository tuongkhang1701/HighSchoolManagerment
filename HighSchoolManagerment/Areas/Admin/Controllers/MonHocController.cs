using HighSchoolManagerment.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class MonHocController : BaseController
    {
        private readonly IMonHoc _subjectService;

        public MonHocController(IMonHoc subjectService)
        {
            _subjectService = subjectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API
        public IActionResult GetAll()
        {
            var subjects = _subjectService.GetAll().ToList();
            return new OkObjectResult(subjects);
        }
        #endregion
    }
}
