using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Wired.Data.Context;
using Wired.Data.Entities;
using Wired.Data.IRepository;

namespace Wired.Data.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly WiredContext _wiredContext;

        public ArticleRepository(WiredContext wiredContext)
        {
            _wiredContext = wiredContext;
        }
        public int Add(Article article)
        {
            var entity = _wiredContext.Articles.Add(article);
            _wiredContext.SaveChanges();
            return entity.Entity.Id;
        }

        public List<Article> GetArticlesFromDb()
        {

            return _wiredContext.Articles.Where(x => x.Status == true).Include("Questions")
                     .ToList();

        }

        public bool IsExist(string guid)
        {
            return _wiredContext.Articles.Where(x => x.TitleGuid == guid).Any();
        }

        public Article GetArticlesFromDb(string guid)
        {
            return _wiredContext.Articles.Where(x => x.TitleGuid == guid).FirstOrDefault();
        }

        public int Update(Article article)
        {
            var entity = _wiredContext.Set<Article>().Update(article);
            entity.State = EntityState.Modified;
            _wiredContext.SaveChanges();
            return entity.Entity.Id;
        }
    }
}
