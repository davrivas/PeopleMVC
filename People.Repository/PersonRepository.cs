using People.Model.Entities;

namespace People.Repository
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
    }

    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
    }
}
