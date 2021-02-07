using System;
using System.Collections.Generic;

namespace Wired.Data.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Contect { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}
