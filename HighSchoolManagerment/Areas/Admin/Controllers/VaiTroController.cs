using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data;
using HighSchoolManagerment.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class VaiTroController : BaseController
    {
        private readonly IVaiTro _roleService;
        public VaiTroController(IVaiTro roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API
        [HttpGet]
        public IActionResult GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            var query = _roleService.GetAll();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Ten.Contains(keyword));
            }
            var rowCount = query.Count();
            var total = query.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToList();
            var pagination = new PaginationResult<Quyen>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                TotalRecord = rowCount,
                Data = total
            };
            return new OkObjectResult(pagination);
        }
        #endregion
    }
}
