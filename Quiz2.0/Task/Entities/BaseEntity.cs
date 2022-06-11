using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Entities
{
    public abstract class BaseEntity
    {
        public abstract void GetInfo();

        public List<T> EntityTable { get; }
        public void PrintAll()
        {
            foreach (var entity in EntityTable)
            {
                entity.GetInfo();
            }
        }
    }
}
