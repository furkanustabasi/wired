using System;
using System.Collections.Generic;
using System.Linq;
using Wired.Data.Entities;
using Wired.Data.IRepository;
using Wired.Service.Abstract;
using Wired.Service.Mapster;
using Wired.Service.Models;
using Wired.Service.Models.Dtos;
using Wired.Service.Models.Response;

namespace Wired.Service.Concrete
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;

        public QuestionsService(IQuestionsRepository questionsRepository, IMapper mapper, IArticleRepository articleRepository)
        {
            _questionsRepository = questionsRepository;
            _mapper = mapper;
            _articleRepository = articleRepository;
        }

        public void Add(QuestionAddModel question)
        {
            var article = _articleRepository.GetArticlesFromDb(question.Guid);
            var updateArticle = article;
            updateArticle.Status = true;


            Question[] questions = new Question[4];

            Question questionEntity1 = new Question
            {
                ArticleId = article.Id,
                Contect = question.MyContent.content1,
                Answer = question.MyAnswer.Answer1,
                CreatedDate = DateTime.Now,
                Status = true,
            };
            questions[0] = (questionEntity1);

            Question questionEntity2 = new Question
            {
                ArticleId = article.Id,
                Contect = question.MyContent.content2,
                Answer = question.MyAnswer.Answer2,
                CreatedDate = DateTime.Now,
                Status = true,
            };
            questions[1] = (questionEntity2);

            Question questionEntity3 = new Question
            {
                ArticleId = article.Id,
                Contect = question.MyContent.content3,
                Answer = question.MyAnswer.Answer3,
                CreatedDate = DateTime.Now,
                Status = true,
            };
            questions[2] = (questionEntity3);

            Question questionEntity4 = new Question
            {
                ArticleId = article.Id,
                Contect = question.MyContent.content4,
                Answer = question.MyAnswer.Answer4,
                CreatedDate = DateTime.Now,
                Status = true,
            };
            questions[3] = (questionEntity4);

            _questionsRepository.Add(questions);

            _articleRepository.Update(updateArticle);
        }

        public QuestionResponseModel Get(int id)
        {

            var entity = _questionsRepository.GetByArticleId(id);

            var response = _mapper.Map<List<Question>, List<QuestionDto>>(entity);

            return new QuestionResponseModel
            {
                Questions = response
            };
        }
    }
}
