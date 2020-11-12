using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Manufacturing;

namespace DataUpload
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