using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaZh
{

    public enum Elhelyezes
    {
        Arbitrary, 
        Horizontal, 
        Vertical
    }

    abstract class Parcel : IDeliverable, IComparable
    {

        public Elhelyezes ElhelyezesMod { get; protected set; }

        public int weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string address { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract double CalculatePrice(bool fromLocker);

        public int CompareTo(object? obj)
        {
            if (obj != null)
            {
                Parcel temp = (Parcel)obj;
                if (this.weight > temp.weight)
                {
                    return 1;
                }
                if (this.weight == temp.weight)
                {
                    return 0;
                }
                if (this.weight < temp.weight)
                {
                    return -1;
                }
            }
            return 0;

        }

        public Parcel(int tomeg, string cimzett, Elhelyezes elhelyezes)
        {
            weight = tomeg;
            address = cimzett;
            ElhelyezesMod = elhelyezes;
        }

        public Parcel(int tomeg, string cimzett) 
        {
            weight = tomeg;
            address = cimzett;
            ElhelyezesMod = Elhelyezes.Arbitrary;
        }

        public override string? ToString()
        {
            return $"Címzett: {address} / Tömeg: {weight} / Elhelyezés: {ElhelyezesMod}";
        }
    }
}
