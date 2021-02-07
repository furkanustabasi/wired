using System;
using System.Collections.Generic;
using System.Text;

namespace Wired.Service.Models.Dtos
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Contect { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
