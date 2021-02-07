using System.Collections.Generic;
using Wired.Service.Models.Dtos;

namespace Wired.Service.Models.Response
{
    public class OptionResponseModel
    {
        public List<OptionDto> Options1 { get; set; }
        public List<OptionDto> Options2 { get; set; }
        public List<OptionDto> Options3 { get; set; }
        public List<OptionDto> Options4 { get; set; }
    }
}
