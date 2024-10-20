using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemoGyak06
{
    public class Book
    {
        private string _konyvSzerzo;
        private string _konyvCim;
        private int _kiadasEv;
        private int _oldalszam;

        public Book(string konyvSzerzo, string konyvCim, int kiadasEv, int oldalszam)
        {
            _konyvSzerzo = konyvSzerzo;
            _konyvCim = konyvCim;
            _kiadasEv = kiadasEv;
            _oldalszam = oldalszam;
        }

        public string AllData()
        {
            return $"Szerző: {_konyvSzerzo} - Könyv címe: {_konyvCim} - Kiadás éve: {_kiadasEv} - Oldalszám: {_oldalszam}";
        }

        public int GetPages()
        {
            return _oldalszam;
        }
    }
}
