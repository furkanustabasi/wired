using System.Collections.Generic;
using Wired.Data.Entities;

namespace Wired.Data.IRepository
{
    public interface IOptionsRepository
    {
        void Add(Option[] options);
        List<Option> GetOptionsByQId(int id);
    }
}
