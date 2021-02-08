using Microsoft.AspNetCore.Mvc;
using System;
using Wired.Service.Abstract;
using Wired.Service.Models;

namespace Wired.Web.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : Controller
    {
        private readonly IArticlesService _articlesService;
        private readonly IQuestionsService _questionsService;
        private readonly IOptionsService _optionsService;

        public HomeController(IArticlesService articlesService, IQuestionsService questionsService, IOptionsService optionsService)
        {
            _articlesService = articlesService;
            _questionsService = questionsService;
            _optionsService = optionsService;
        }

        [HttpGet]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [Route("index")]
        public IActionResult Index([FromBody] QuestionAddModel question)
        {
            try
            {
                int articleId = Convert.ToInt32(question.ArticleId);
                _articlesService.Add(articleId);

                _questionsService.Add(question);

                _optionsService.Add(question);

                return View();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }


        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        [Route("exam")]
        public IActionResult Exam(/*[FromBody] string guid*/)
        {
            try
            {
                //QuestionList View is not working properly and we sending data directly to controller for testing
                var entity = _articlesService.GetArticlesFromDb();
                var a = "";
                foreach (var item in entity)
                {
                    a = item.Guid;
                }
                var article = _articlesService.GetArticlesFromDb(a);
                var questions = _questionsService.Get(article.Id);
                int[] ids = new int[4];
                int i = 0;
                foreach (var item in questions.Questions)
                {
                    ids[i] = item.Id;
                    i++;
                }

                var options = _optionsService.GetOptions(ids[0], ids[1], ids[2], ids[3]);
                ViewData["myArticle"] = article;
                ViewData["myQuestions"] = questions;
                ViewData["myOptions"] = options;

                return View();
            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        [HttpGet]
        [Route("questionlist")]
        public IActionResult QuestionList()
        {
            try
            {
                var entity = _articlesService.GetArticlesFromDb();
                ViewData["myResponse"] = entity;
                return View();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        [HttpPost]
        [Route("questionlist")]
        public IActionResult QuestionList([FromBody] string myGuid)
        {
            try
            {
                var inActiveArticleId = _articlesService.InactiveArticleExam(myGuid);
                var entity = _articlesService.GetArticlesFromDb();
                ViewData["myResponse"] = entity;

                return Ok(inActiveArticleId.Id);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
