using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaZh
{
    class FragileParcel : Parcel
    {
        public FragileParcel(int tomeg, string cimzett, Elhelyezes elhelyezes) : base(tomeg, cimzett, elhelyezes)
        {
            if (elhelyezes == Elhelyezes.Arbitrary)
            {
                throw new IncorrectOrientationException(this);
            }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            if (fromLocker)
            {
                throw new DeliveryException("Nem adható fel autómatából");
            }
            return 1000 + this.weight * 2;
        }
    }
}
