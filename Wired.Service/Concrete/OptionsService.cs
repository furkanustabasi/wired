using System.Collections.Generic;
using Wired.Data.Entities;
using Wired.Data.IRepository;
using Wired.Service.Abstract;
using Wired.Service.Mapster;
using Wired.Service.Models;
using Wired.Service.Models.Dtos;
using Wired.Service.Models.Response;

namespace Wired.Service.Concrete
{
    public class OptionsService : IOptionsService
    {
        private readonly IOptionsRepository _optionsRepository;
        private readonly IQuestionsRepository _questionsRepository;
        private readonly IMapper _mapper;


        public OptionsService(IOptionsRepository optionsRepository, IMapper mapper, IQuestionsRepository questionsRepository)
        {
            _optionsRepository = optionsRepository;
            _mapper = mapper;
            _questionsRepository = questionsRepository;
        }


        public void Add(QuestionAddModel model)
        {
            var questionIds = _questionsRepository.GetLastRecordsById(4);

            //PropertyInfo[] properties = typeof(QuestionAddModel).GetProperties();
            //foreach (var item in properties)
            //{
            //        item.GetValue()
            //}


            Option[] options = new Option[16];

            Option option1 = new Option
            {
                QuestionId = questionIds[3],
                Description = model.MyOptions.options1.Q1OptionA,
                Status = true
            };
            options[0] = (option1);

            Option option2 = new Option
            {
                QuestionId = questionIds[3],
                Description = model.MyOptions.options1.Q1OptionB,
                Status = true
            };
            options[1] = (option2);

            Option option3 = new Option
            {
                QuestionId = questionIds[3],
                Description = model.MyOptions.options1.Q1OptionC,
                Status = true
            };
            options[2] = (option3);

            Option option4 = new Option
            {
                QuestionId = questionIds[3],
                Description = model.MyOptions.options1.Q1OptionD,
                Status = true
            };
            options[3] = (option4);

            Option option5 = new Option
            {
                QuestionId = questionIds[2],
                Description = model.MyOptions.options2.Q2OptionA,
                Status = true
            };
            options[4] = (option5);

            Option option6 = new Option
            {
                QuestionId = questionIds[2],
                Description = model.MyOptions.options2.Q2OptionB,
                Status = true
            };
            options[5] = (option6);

            Option option7 = new Option
            {
                QuestionId = questionIds[2],
                Description = model.MyOptions.options2.Q2OptionC,
                Status = true
            };
            options[6] = (option7);

            Option option8 = new Option
            {
                QuestionId = questionIds[2],
                Description = model.MyOptions.options2.Q2OptionD,
                Status = true
            };
            options[7] = (option8);

            Option option9 = new Option
            {
                QuestionId = questionIds[1],
                Description = model.MyOptions.options3.Q3OptionA,
                Status = true
            };
            options[8] = (option9);

            Option option10 = new Option
            {
                QuestionId = questionIds[1],
                Description = model.MyOptions.options3.Q3OptionB,
                Status = true
            };
            options[9] = (option10);

            Option option11 = new Option
            {
                QuestionId = questionIds[1],
                Description = model.MyOptions.options3.Q3OptionC,
                Status = true
            };
            options[10] = (option11);

            Option option12 = new Option
            {
                QuestionId = questionIds[1],
                Description = model.MyOptions.options3.Q3OptionD,
                Status = true
            };
            options[11] = (option12);

            Option option13 = new Option
            {
                QuestionId = questionIds[0],
                Description = model.MyOptions.options4.Q4OptionA,
                Status = true
            };
            options[12] = (option13);

            Option option14 = new Option
            {
                QuestionId = questionIds[0],
                Description = model.MyOptions.options4.Q4OptionB,
                Status = true
            };
            options[13] = (option14);

            Option option15 = new Option
            {
                QuestionId = questionIds[0],
                Description = model.MyOptions.options4.Q4OptionC,
                Status = true
            };
            options[14] = (option15);

            Option option16 = new Option
            {
                QuestionId = questionIds[0],
                Description = model.MyOptions.options4.Q4OptionD,
                Status = true
            };
            options[15] = (option16);

            _optionsRepository.Add(options);
        }


        public OptionResponseModel GetOptions(int id1, int id2, int id3, int id4)
        {
            var response1 = _optionsRepository.GetOptionsByQId(id1);
            var response2 = _optionsRepository.GetOptionsByQId(id2);
            var response3 = _optionsRepository.GetOptionsByQId(id3);
            var response4 = _optionsRepository.GetOptionsByQId(id4);

            var entity1 = _mapper.Map<List<Option>, List<OptionDto>>(response1);
            var entity2 = _mapper.Map<List<Option>, List<OptionDto>>(response2);
            var entity3 = _mapper.Map<List<Option>, List<OptionDto>>(response3);
            var entity4 = _mapper.Map<List<Option>, List<OptionDto>>(response4);

            return new OptionResponseModel
            {
                Options1 = entity1,
                Options2 = entity2,
                Options3 = entity3,
                Options4 = entity4
            };
        }
    }
}
