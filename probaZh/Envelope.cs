using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaZh
{
    class Envelope : IDeliverable
    {
        public int weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string leiras;
        public Envelope(int tomeg, string cimzett, string leiras) 
        {

            weight = tomeg;
            address = cimzett;
            this.leiras = leiras;

        }

        public int szallitasiDij()
        {
            if (this.weight <= 50)
            {
                return 200;
            }
            if (this.weight >= 51 && this.weight <= 500)
            {
                return 400;
            }
            if (this.weight >= 501 && this.weight <= 2000)
            {
                return 1000;
            }
            else
            {
                throw new OverweightException();
            }
        }

        public override string? ToString()
        {
            return $"Címzett: {address} / Leírás: {leiras} / Tömeg:{weight} g";
        }

        public double CalculatePrice(bool fromLocker)
        {
            throw new NotImplementedException();
        }
    }
}
