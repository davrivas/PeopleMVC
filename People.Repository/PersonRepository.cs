using People.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Repository
{
    public interface IPersonRepository : IBaseRepository<IPerson>
    {
    }

    public class PersonRepository : BaseRepository<IPerson>, IPersonRepository
    {
    }
}
