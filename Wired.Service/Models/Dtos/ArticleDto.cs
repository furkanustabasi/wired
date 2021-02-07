using System;
using System.Collections.Generic;
using System.Text;

namespace Wired.Service.Models.Dtos
{
    public class ArticleDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contect { get; set; }
        public string TitleGuid { get; set; }
        public bool Status { get; set; }
    }
}
