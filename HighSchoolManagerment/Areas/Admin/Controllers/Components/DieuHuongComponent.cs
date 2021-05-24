using HighSchoolManagerment.Data;
using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Areas.Admin.Controllers.Components
{
    public class DieuHuongViewComponent : ViewComponent
    {
        private readonly IChucNang _functionService;
        public DieuHuongViewComponent(IChucNang functionService)
        {
            _functionService = functionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<ChucNang> functions = await _functionService.GetAll().OrderBy(x => x.Ten).ToListAsync();
            return View(functions);
        }
    }
}
