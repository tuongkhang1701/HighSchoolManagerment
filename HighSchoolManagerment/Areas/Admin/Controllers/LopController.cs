using HighSchoolManagerment.Common;
using HighSchoolManagerment.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class LopController : BaseController
    {
        private readonly ILop _lop;
        public LopController(ILop lop)
        {
            _lop = lop;
        }


        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 4)
        {
            var request = new GetUserPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _lop.GetAllPaging(request);
            ViewBag.Keyword = keyword;
            return View(data);
        }

        /*public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return new OkObjectResult(users);
        }

        public IActionResult RemoveById(int id)
        {
            _userService.RemoveById(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return new OkObjectResult(user);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var user = _userService.GetById(id);
            ViewBag.GioiTinh = new SelectList(_userService.GetGender().ToList(), "MaGT", "Ten", _userService.GetGender().FirstOrDefault(x => x.MaGT == user.MaGT));
            ViewBag.TonGiao = new SelectList(_userService.GetReligion().ToList(), "MaTG", "Ten", _userService.GetReligion().FirstOrDefault(x => x.MaTG == user.MaTG));
            ViewBag.NhomNguoiDung = new SelectList(_userService.GetReligion().ToList(), "MaNND", "Ten", _userService.GetUserGroup().FirstOrDefault(x => x.MaNND == user.MaNND));
            return View(user);
        }

        [HttpPost]
        public IActionResult Update(NguoiDung user)
        {
            if (ModelState.IsValid)
            {
                _userService.Update(user);
                if (user.role == "GV")
                {
                    return Redirect("/admin/nguoidung/index?UserGroupId=GIAOVIEN");
                }
                return Redirect("/admin/nguoidung/index?UserGroupId=HOCSINH");
            }
            return View(user);
        }*/

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NguoiDung user)
        {
            if (ModelState.IsValid)
            {
                _userService.Add((user));
                if (user.role == "GV")
                {
                    return RedirectToAction("/admin/nguoidung/index?UserGroupId=GIAOVIEN");
                }
                return Redirect("/admin/nguoidung/index?UserGroupId=HOCSINH");
            }
            return View(user);
        }

        /*public IActionResult Remove(int id, string role)
        {
            _userService.RemoveById(id);

            if (role == "GV")
            {
                return Redirect("/admin/nguoidung/index?UserGroupId=GIAOVIEN");
            }
            return Redirect("/admin/nguoidung/index?UserGroupId=HOCSINH");
        }*/
    }
}
