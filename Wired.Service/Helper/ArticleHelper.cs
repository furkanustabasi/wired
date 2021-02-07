using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;
using Wired.Data.Entities;

namespace Wired.Service.Helper
{
    public static class ArticleHelper
    {
        private const string url = "https://www.wired.com/feed/rss";

        public static Article GetArticlesById(int index)
        {
            using var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);

            var posts = feed.Items
                        .Take(5);
            var entities = posts.Select(x => new
            {
                x.Title,
                x.Summary,
                x.Id
            }).ToList();

            List<Article> articles = new List<Article>();

            foreach (var item in entities)
            {
                Article article = new Article
                {
                    TitleGuid = item.Id.ToString(),
                    Title = item.Title.Text,
                    Contect = item.Summary.Text,
                    Status = false,
                };

                articles.Add(article);
            }

            return articles[index];
        }
    }
}
