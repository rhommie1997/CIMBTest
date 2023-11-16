using CIMBTest.Services.Abstract;
using CIMBTest.Services.Services;
using CIMBTest.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CIMBTest.Controllers
{
    public class UseCase3Controller : Controller
    {
        private readonly ICommonService commonService;

        public UseCase3Controller(ICommonService _cs)
        {
            commonService = _cs;
        }

        public IActionResult Index()
        {
            List<UseCase3ViewModel> data = commonService.GetAllUseCase3List();

            return View(data);
        }
    }
}
