using System;
using Contracts;
using DataUpload;
using Manufacturing;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var serializer = new Serializer();
            var streamOfAggregates = new[] { new Aggregate(new[] { new Entity(3), new Entity(4) }), new Aggregate(new[] { new Entity(8) })};
            var uploadProcessManager = new UploadProcessManager(streamOfAggregates, serializer);
            uploadProcessManager.ProcessUpload();
        }
    }

    public class Serializer : ISerializer
    {
        public void Serialize(IAggregatePublicContract publicContract)
        {
            System.Console.WriteLine($"Uploading public contract for {nameof(IAggregatePublicContract)} with total size of {publicContract.TotalSize}");
        }
    }
}
