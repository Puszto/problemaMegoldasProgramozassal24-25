using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaZh
{
    class NormalParcel : Parcel
    {
        public NormalParcel(int tomeg, string cimzett) : base (tomeg, cimzett)
        {
            Random rnd = new Random();
            int tmp = rnd.Next(3);
            if (tmp == 0)
            {
                this.ElhelyezesMod = Elhelyezes.Arbitrary;
            }
            if (tmp == 1)
            {
                this.ElhelyezesMod = Elhelyezes.Horizontal;
            }
            else
            {
                this.ElhelyezesMod = Elhelyezes.Vertical;
            }
        }

        public override double CalculatePrice(bool fromLocker)
        {
            if (fromLocker)
            {
                return 500 + this.weight - 250;
            }
            return 500 + this.weight;
        }
    }
}
