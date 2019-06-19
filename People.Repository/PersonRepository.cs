using People.Model.Entities;

namespace People.Repository
{
    public interface IPersonRepository<T> : IBaseRepository<T> where T : IPerson
    {
    }

    public class PersonRepository : BaseRepository<Person>, IPersonRepository<Person>
    {
    }
}
