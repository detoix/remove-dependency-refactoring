using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;

namespace DataUpload
{
    public class UploadProcessManager
    {
        private IEnumerable<IAggregatePublicContract> StreamOfAggregates { get; }
        private ISerializer Serializer { get; }

        public UploadProcessManager(
            IEnumerable<IAggregatePublicContract> streamOfAggregates,
            ISerializer serialize)
        {
            this.StreamOfAggregates = streamOfAggregates;
            this.Serializer = serialize;
        }

        public void ProcessUpload()
        {
            foreach (var publicContract in this.StreamOfAggregates)
            {
                this.Serializer.Serialize(publicContract);
            }
        }
    }
}
