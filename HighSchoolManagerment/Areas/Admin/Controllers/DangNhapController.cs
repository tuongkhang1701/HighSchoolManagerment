using HighSchoolManagerment.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class DangNhapController : BaseController
    {
        private readonly INguoiDung _userService;

        public DangNhapController(INguoiDung userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Index(string email, string password)
        {
            *//*var result = _userService.FindByEmail(email);
            if (result != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return new OkResult();
            }*//*
        }*/
    }
}