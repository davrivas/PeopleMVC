using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Model.Entities
{
    public interface IPerson : IBaseEntity
    {
        string Name { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        
    }

    public class Person/* : BaseEntity, IPerson*/
    {

    }
}
