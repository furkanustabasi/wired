using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using Wired.Data.Context;
using Wired.Data.Entities;
using Wired.Data.IRepository;

namespace Wired.Data.Repository
{
    public class OptionsRepository : IOptionsRepository
    {
        private readonly WiredContext _wiredContext;

        public OptionsRepository(WiredContext wiredContext)
        {
            _wiredContext = wiredContext;
        }

        public void Add(Option[] options)
        {
            _wiredContext.Options.AddRange(options);
            _wiredContext.SaveChanges();
        }

        public List<Option> GetOptionsByQId(int id)
        {
            return _wiredContext.Options.Where(x => x.QuestionId == id).ToList();
        }
    }
}
