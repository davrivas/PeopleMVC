﻿namespace People.Model.Entities
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
