using Wired.Service.Models;
using Wired.Service.Models.Response;

namespace Wired.Service.Abstract
{
    public interface IOptionsService
    {
        void Add(QuestionAddModel model);
        OptionResponseModel GetOptions(int id1, int id2, int id3, int id4);
    }
}
