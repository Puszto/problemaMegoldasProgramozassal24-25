using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaZh
{
     class Courier
    {

        IDeliverable[] tomb;
        int ind = -1;
        public int ossztomeg 
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] != null)
                    {
                        sum = sum + tomb[i].weight;
                    }
                }
                return sum;
            }
        }

        public Courier(int elemszam)
        {
            this.tomb = new IDeliverable[elemszam];   
        }

        void PickUpItem(IDeliverable item)
        {
            if (ind > tomb.Length-1)
            {
                throw new DeliveryException("Nincs több hely");
            }
            ind++;
            tomb[ind] = item;
        }

        IDeliverable[]? FragilesSorted()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] is FragileParcel)
                {
                    db++;
                }
            }

            if (db == 0)
            {
                return null;
            }

            int index = 0;
            IDeliverable[] result = new IDeliverable[db];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] is FragileParcel)
                {
                    result[index] = tomb[i];
                    index++;
                }
            }

            Array.Sort(result);

            return result;

        }

    }
}
