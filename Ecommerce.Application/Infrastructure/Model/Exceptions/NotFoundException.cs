using System;
using System.Runtime.Serialization;

namespace Ecommerce.Application.Infrastructure.Model.Exceptions
{
    [Serializable]
    internal class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string name, object key)
           : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}