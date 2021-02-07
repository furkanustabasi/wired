using System;
using System.Collections.Generic;

namespace Wired.Data.Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Contect { get; set; }
        public string TitleGuid { get; set; }
        public bool Status { get; set; }
        public virtual ICollection<Question> Questions
        {
            get; set;
        }
    }
}
