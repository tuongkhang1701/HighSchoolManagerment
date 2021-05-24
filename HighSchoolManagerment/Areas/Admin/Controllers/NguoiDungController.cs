using HighSchoolManagerment.Application.Interfaces;
using HighSchoolManagerment.Areas.Admin.Controllers;
using HighSchoolManagerment.Common;
using HighSchoolManagerment.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Controllers
{
    public class NguoiDungController : BaseController
    {
        private readonly INguoiDung _userService;

        public NguoiDungController(INguoiDung userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index(string keyword, string UserGroupId, int pageIndex = 1, int pageSize = 4)
        {
            var request = new GetUserPagingRequest()
            {
                UserGroupId = UserGroupId,
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userService.GetAllPaging(request);
            ViewBag.Keyword = keyword;
            return View(data);
        }

        public IActionResult GetAll()
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
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.GioiTinh = new SelectList(_userService.GetGender().ToList(), "MaGT", "Ten");
            ViewBag.TonGiao = new SelectList(_userService.GetReligion().ToList(), "MaTG", "Ten");
            ViewBag.NhomNguoiDung = new SelectList(_userService.GetUserGroup().ToList(), "MaNND", "Ten");
            return View(new NguoiDung());
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

        public IActionResult Remove(int id, string role)
        {
            _userService.RemoveById(id);

            if (role == "GV")
            {
                return Redirect("/admin/nguoidung/index?UserGroupId=GIAOVIEN");
            }
            return Redirect("/admin/nguoidung/index?UserGroupId=HOCSINH");
        }

        /*[HttpPost]
        public IActionResult Search(string keyword)
        {
        }*/

        //http://localhost/api/admin/user/paging?pageIndex=1&pageSize=10&keyword=
        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetUserPagingRequest request)
        {
            var users = await _userService.GetAllPaging(request);
            return Ok(users);
        }
    }
}