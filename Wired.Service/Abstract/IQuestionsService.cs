using Wired.Service.Models;
using Wired.Service.Models.Response;

namespace Wired.Service.Abstract
{
    public interface IQuestionsService
    {
        void Add(QuestionAddModel question);
        QuestionResponseModel Get(int id);
    }
}
