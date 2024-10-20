using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemoGyak06
{
    public class Runner
    {
        private string _futoNev;
        private int _sorszam;
        private int _sebesseg;
        private int _tavolsag;

        public Runner(string futoNev, int sorszam, int sebesseg)
        {
            _futoNev = futoNev;
            _sorszam = sorszam;
            _sebesseg = sebesseg;
            _tavolsag = 0;
        }

        public void RefreshDistance(int masodperc)
        {
            _tavolsag += _sebesseg * masodperc;
        }

        public void Show()
        {
            for (int i = 0; i < GetDistance(); i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(_futoNev[0]);
        }

        public int GetDistance()
        {
            return _tavolsag;
        }
    }
}
