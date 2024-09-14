using System.Runtime.Serialization;

namespace probaZh
{
    [Serializable]
    internal class DeliveryException : Exception
    {
        public DeliveryException(string? message) : base(message)
        {
        }
    }
}