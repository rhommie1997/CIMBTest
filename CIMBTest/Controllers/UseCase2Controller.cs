using CIMBTest.Services.Abstract;
using CIMBTest.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CIMBTest.Controllers
{
    public class UseCase2Controller : Controller
    {
        private readonly ICommonService commonService;

        public UseCase2Controller(ICommonService _cs)
        {
            commonService = _cs;
        }

        public IActionResult Index()
        {
            List<UseCase2ViewModel> data = commonService.GetAllUseCase2List();

            return View(data);
        }
    }
}
