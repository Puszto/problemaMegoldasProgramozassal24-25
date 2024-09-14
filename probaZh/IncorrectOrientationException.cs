using System.Runtime.Serialization;

namespace probaZh
{
    [Serializable]
    internal class IncorrectOrientationException : Exception
    {
        private FragileParcel fragileParcel;

        public IncorrectOrientationException(FragileParcel fragileParcel)
        {
            this.fragileParcel = fragileParcel;
        }
    }
}