using HighSchoolManagerment.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HighSchoolManagerment.Areas.Admin.Controllers.Components
{
    public class PhanTrangViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PaginationBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}