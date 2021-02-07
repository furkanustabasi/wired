using System.Collections.Generic;
using Wired.Data.Entities;

namespace Wired.Data.IRepository
{
    public interface IArticleRepository
    {
        int Add(Article article);
        int Update(Article article);
        List<Article> GetArticlesFromDb();
        Article GetArticlesFromDb(string guid);
        bool IsExist(string guid);
    }
}
