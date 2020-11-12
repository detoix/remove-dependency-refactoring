using System;
using System.Collections.Generic;
using System.Linq;
using Contracts;

namespace DataUpload
{
    public interface ISerializer
    {
        void Serialize(IAggregatePublicContract publicContract);
    }
}