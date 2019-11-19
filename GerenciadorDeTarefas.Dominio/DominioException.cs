using System;
using System.Runtime.Serialization;

namespace GerenciadorDeTarefas.Dominio
{
    public class DominioException : Exception
    {
        public DominioException()
        {
        }

        public DominioException(string message) : base(message)
        {
        }

        public DominioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DominioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}