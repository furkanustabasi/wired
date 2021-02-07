namespace Wired.Service.Models
{
    public class QuestionAddModel 
    {
 
        public string ArticleId { get; set; }
        public string Guid { get; set; }
        public Content MyContent { get; set; }
        public Answer MyAnswer { get; set; }
        public Options MyOptions { get; set; }

        public class Content
        {
            public string content1 { get; set; }
            public string content2 { get; set; }
            public string content3 { get; set; }
            public string content4 { get; set; }
        }

        public class Answer
        {
            public string Answer1 { get; set; }
            public string Answer2 { get; set; }
            public string Answer3 { get; set; }
            public string Answer4 { get; set; }
        }

        public class Options1
        {
            public string Q1OptionA { get; set; }
            public string Q1OptionB { get; set; }
            public string Q1OptionC { get; set; }
            public string Q1OptionD { get; set; }
        }

        public class Options2
        {
            public string Q2OptionA { get; set; }
            public string Q2OptionB { get; set; }
            public string Q2OptionC { get; set; }
            public string Q2OptionD { get; set; }
        }

        public class Options3
        {
            public string Q3OptionA { get; set; }
            public string Q3OptionB { get; set; }
            public string Q3OptionC { get; set; }
            public string Q3OptionD { get; set; }
        }

        public class Options4
        {
            public string Q4OptionA { get; set; }
            public string Q4OptionB { get; set; }
            public string Q4OptionC { get; set; }
            public string Q4OptionD { get; set; }
        }

        public class Options
        {
            public Options1 options1 { get; set; }
            public Options2 options2 { get; set; }
            public Options3 options3 { get; set; }
            public Options4 options4 { get; set; }
        }
    }
}
