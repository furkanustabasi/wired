using System.Collections.Generic;
using System.Linq;
using Wired.Data.Context;
using Wired.Data.Entities;
using Wired.Data.IRepository;

namespace Wired.Data.Repository
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly WiredContext _wiredContext;

        public QuestionsRepository(WiredContext wiredContext)
        {
            _wiredContext = wiredContext;
        }

        public void Add(Question[] question)
        {
            _wiredContext.Questions.AddRange(question);
            _wiredContext.SaveChanges();
        }

        public List<Question> GetAll()
        {
            return _wiredContext.Questions.ToList();
        }

        public List<Question> GetByArticleId(int articleId)
        {
            return _wiredContext.Questions.Where(x => x.ArticleId == articleId).ToList();
        }


        public List<int> GetLastRecordsById(int number)
        {
            return _wiredContext.Questions.OrderByDescending(i => i.Id).Take(number).Select(x => x.Id).ToList();
        }
    }
}
