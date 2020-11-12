using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;

namespace Manufacturing
{
    public class AggregatePublicContract : IAggregatePublicContract
    {
        private Aggregate Aggregate { get; }

        public int TotalSize => this.Aggregate.Children.Sum(e => e.Size);

        public AggregatePublicContract(Aggregate aggregate)
        {
            this.Aggregate = aggregate;
        }
    }
}