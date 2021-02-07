using Microsoft.AspNetCore.Mvc;
using Wired.Service.Abstract;

namespace Wired.Web.Controllers
{
    [ApiController]
    [Route("article")]
    public class ArticleController : Controller
    {
        private readonly IArticlesService _articlesService;
        private readonly IQuestionsService _questionService;

        public ArticleController(IArticlesService articlesService, IQuestionsService questionsService)
        {
            _articlesService = articlesService;
            _questionService = questionsService;
        }

        [HttpGet]
        [Route("aa")]
        public IActionResult GetAll()
        {
         

            return Ok();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add( )
        {

            return Ok();
        }

    }
}
