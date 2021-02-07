using System;
using System.Collections.Generic;
using System.Text;

namespace Wired.Service.Models.Request
{
    public class QuestionRequestModel
    {
        public int ArticleId { get; set; }
        public string Contect { get; set; }
        public string Answer { get; set; }
    }
}
