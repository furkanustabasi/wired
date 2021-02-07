using System.Collections.Generic;
using System.Linq;
using Wired.Data.IRepository;
using Wired.Service.Abstract;
using Wired.Service.Helper;
using Wired.Service.Models.Response;

namespace Wired.Service.Concrete
{
    public class ArticlesService : IArticlesService
    {


        private readonly IArticleRepository _articleRepository;

        public ArticlesService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public BaseResponseModel Add(int index)
        {
            var entity = ArticleHelper.GetArticlesById(index);

            var isExist = _articleRepository.IsExist(entity.TitleGuid);

            if (isExist)
            {
                var exist = _articleRepository.GetArticlesFromDb(entity.TitleGuid);

                return new BaseResponseModel
                {
                    Id = exist.Id
                };
            }

            var response = _articleRepository.Add(entity);

            return new BaseResponseModel
            {
                Id = response
            };
        }

        public List<QuestionListResponseModel> GetArticlesFromDb()
        {

            var entities = _articleRepository.GetArticlesFromDb();

            QuestionListResponseModel qlModel;
            List<QuestionListResponseModel> qlModelList = new List<QuestionListResponseModel>();

            foreach (var item in entities)
            {
                qlModel = new QuestionListResponseModel
                {
                    Title = item.Title,
                    Guid = item.TitleGuid,
                    CreatedDate = "22222222"
                };

                qlModelList.Add(qlModel);
            }

            return qlModelList;
        }

        public ArticleResponseModel GetArticlesFromDb(string guid)
        {

            var entity = _articleRepository.GetArticlesFromDb(guid);

            ArticleResponseModel arModel = new ArticleResponseModel
            {
                Id = entity.Id,
                Contect = entity.Contect,
                TitleGuid = entity.TitleGuid,
                Title = entity.Title,
                Status = entity.Status
            };
            return arModel;
        }
    }
}
