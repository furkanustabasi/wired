using System;
using System.Collections.Generic;
using System.Text;

namespace Wired.Service.Models.Dtos
{
    public class OptionDto
    {
        public int QuestionId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
