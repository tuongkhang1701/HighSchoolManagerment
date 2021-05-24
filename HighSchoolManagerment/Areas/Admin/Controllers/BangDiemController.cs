using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class BangDiemController : BaseController
    {
        private readonly IBangDiem _scoreBoardService;

        public BangDiemController(IBangDiem scoreBoardService)
        {
            _scoreBoardService = scoreBoardService;
        }

        public IActionResult Index(int id)
        {
            var models = _scoreBoardService.GetByUserId(id);
            return View(models);
        }

        public IActionResult GetByUserId(int id)
        {
            var models = _scoreBoardService.GetByUserId(id);
            return View(models);
        }

        [HttpGet]
        public IActionResult Update(int MaBD)
        {
            var models = _scoreBoardService.GetByMaBD(MaBD);
            return View(models);
        }

        [HttpPost]
        public IActionResult Update(BangDiem model)
        {
            _scoreBoardService.Update(model);
            return Redirect("/admin/bangdiem/getbyuserId/" + model.MaND);
        }
    }
}