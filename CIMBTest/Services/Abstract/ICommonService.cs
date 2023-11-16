using CIMBTest.ViewModels;

namespace CIMBTest.Services.Abstract
{
    public interface ICommonService
    {
        UseCase1ViewModel GetData(int dpd, int col);

        List<UseCase2ViewModel> GetAllUseCase2List();
        List<UseCase3ViewModel> GetAllUseCase3List();
    }
}
