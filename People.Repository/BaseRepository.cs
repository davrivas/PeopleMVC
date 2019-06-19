﻿using People.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People.Repository
{
    public interface IBaseRepository<T>
    {
    }

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : IBaseEntity
    {
    }
}
