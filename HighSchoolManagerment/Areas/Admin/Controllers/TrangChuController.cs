using Microsoft.AspNetCore.Mvc;

namespace HighSchoolManagerment.Areas.Admin.Controllers
{
    public class TrangChuController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}