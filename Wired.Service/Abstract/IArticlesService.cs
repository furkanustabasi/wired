using System.Collections.Generic;
using Wired.Service.Models.Response;

namespace Wired.Service.Abstract
{
    public interface IArticlesService
    {
        List<QuestionListResponseModel> GetArticlesFromDb();
        BaseResponseModel Add(int index);
        ArticleResponseModel GetArticlesFromDb(string guid);
        ArticleResponseModel InactiveArticleExam(string guid);
    }
}
