using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemoGyak06
{
    public class Titkosit
    {
        private int _kulcs;
        public Titkosit(int kulcs)
        {
            _kulcs = kulcs;
        }

        private string TransformMessage(string message, int kulcs)
        {
            string transformedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                int currentChar = message[i];
                currentChar += kulcs;

                char transformed = (char)(currentChar);
                transformedMessage += transformed;
            }

            return transformedMessage;
        }

        public string Encode(string message)
        {
            return TransformMessage(message, _kulcs);
        }

        public string Decode(string message)
        {
            return TransformMessage(message, _kulcs * -1);
        }


    }
}
