using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;
using Manufacturing;

namespace DataUpload
{
    public class UploadProcessManager
    {
        private IEnumerable<Aggregate> StreamOfAggregates { get; }
        private ISerializer Serializer { get; }

        public UploadProcessManager(
            IEnumerable<Aggregate> streamOfAggregates,
            ISerializer serialize)
        {
            this.StreamOfAggregates = streamOfAggregates;
            this.Serializer = serialize;
        }

        public void ProcessUpload()
        {
            foreach (var aggregate in this.StreamOfAggregates)
            {
                var publicContract = new AggregatePublicContract(aggregate);
                this.Serializer.Serialize(publicContract);
            }
        }
    }
}
