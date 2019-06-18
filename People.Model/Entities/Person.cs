using People.Model.Enums;
using System;

namespace People.Model.Entities
{
    public interface IPerson : IBaseEntity
    {
        string Name { get; set; }
        string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        Sex Sex { get; set; }
        MaritalStatus MaritalStatus { get; set; }
        EducationLevel EducationLevel { get; set; }
        WorkingStatus WorkingStatus { get; set; }
    }

    public class Person : BaseEntity, IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public WorkingStatus WorkingStatus { get; set; }
    }
}
