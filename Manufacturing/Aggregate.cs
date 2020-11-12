using System;
using System.Collections.Generic;

namespace Manufacturing
{
    public class Aggregate
    {
        public IReadOnlyCollection<Entity> Children { get; }

        public Aggregate(IReadOnlyCollection<Entity> children)
        {
            this.Children = children;
        }
    }

    public class Entity
    {
        public int Size { get; }

        public Entity(int size)
        {
            this.Size = size;
        }
    }
}
