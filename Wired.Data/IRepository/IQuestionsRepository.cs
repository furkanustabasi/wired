using System;
using System.Collections.Generic;
using System.Text;
using Wired.Data.Entities;

namespace Wired.Data.IRepository
{
    public interface IQuestionsRepository
    {
        void Add(Question[] question);
        List<Question> GetAll();
        List<int> GetLastRecordsById(int number);
        List<Question> GetByArticleId(int articleId);

    }
}
