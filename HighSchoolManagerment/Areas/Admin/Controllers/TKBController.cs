using HighSchoolManagerment.Data.Entities;
using HighSchoolManagerment.Interfaces;
using HighSchoolManagerment.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class TKBController : BaseController
    {
        private readonly ITKB _tkb;
        private readonly ILop _lop;
        private readonly INamHoc _namhoc;

        public TKBController(ITKB tkb, ILop lop, INamHoc namhoc)
        {
            _tkb = tkb;
            _lop = lop;
            _namhoc = namhoc;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.NamHoc = new SelectList(_namhoc.GetAll(), "MaNH", "Ten", "0");
            ViewBag.Lop = new SelectList(_lop.GetAll(), "MaLop", "Ten", "0");
            TKBViewModel list = new TKBViewModel();
            list.TKB = _tkb.GetAll(1);
            return View(list);
        }

        [HttpPost]
        public IActionResult Index(int MaNH = 0, string Buoi = null, int MaLop = 0)
        {
            ViewBag.NamHoc = new SelectList(_namhoc.GetAll(), "MaNH", "Ten", _namhoc.GetAll().FirstOrDefault(x => x.MaNH == MaNH));
            ViewBag.Lop = new SelectList(_lop.GetAll(), "MaLop", "Ten", _lop.GetAll().FirstOrDefault(x => x.MaLop == MaLop));
            TKBViewModel list = new TKBViewModel();
            if (MaNH == 0 && Buoi == null && MaLop == 0)
            {
                list.TKB = _tkb.GetByNH(MaNH);
            }
            else if (MaNH != 0 && Buoi != null && MaLop == 0)
            {
                list.TKB = _tkb.GetByBuoi(MaNH, Buoi);
            }
            else if (MaNH != 0 && Buoi != null && MaLop != 0)
            {
                list.TKB = _tkb.GetByMaLop(MaNH, Buoi, MaLop);
            }
            else
            {
                list.TKB = _tkb.GetAll(1);
            }
            if (list.TKB.Count == 0)
            {
                list.Notify = "Thời khóa biểu đang được cập nhật, vui lòng quay lại sau!";
                return View(list);
            }
            return View(list);
        }
    }
}