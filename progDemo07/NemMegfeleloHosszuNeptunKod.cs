
namespace progDemo07
{
    [Serializable]
    internal class NemMegfeleloHosszuNeptunKod : Exception
    {
        public NemMegfeleloHosszuNeptunKod()
        {
        }

        public NemMegfeleloHosszuNeptunKod(string? message) : base(message)
        {
        }

        public NemMegfeleloHosszuNeptunKod(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}