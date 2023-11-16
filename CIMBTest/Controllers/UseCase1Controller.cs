using CIMBTest.Services.Abstract;
using CIMBTest.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CIMBTest.Controllers
{
    public class UseCase1Controller : Controller
    {
        private readonly ICommonService commonService;

        public UseCase1Controller(ICommonService _cs)
        {
            commonService = _cs;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(int dpd, int collectability)
        {
            UseCase1ViewModel data = commonService.GetData(dpd,collectability);

            return PartialView("_Preview",data);
        }
    }
}
