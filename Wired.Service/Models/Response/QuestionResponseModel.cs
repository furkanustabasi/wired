using System;
using System.Collections.Generic;
using System.Text;
using Wired.Service.Models.Dtos;

namespace Wired.Service.Models.Response
{
    public class QuestionResponseModel : BaseResponseModel
    {

        public List<QuestionDto> Questions { get; set; }
    }
}
