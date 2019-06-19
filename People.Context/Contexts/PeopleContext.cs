using People.Model.Entities;
using System.Data.Entity;

namespace People.Context.Contexts
{
    public sealed class PeopleContext : DbContext
    {
        public PeopleContext() : base("Data Source=DESKTOP-3Q3B28H;Initial Catalog=People;Integrated Security=True")
        {
        }

        public IDbSet<Person> People { get; set; }
    }
}
