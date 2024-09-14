using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaZh
{
     public interface IDeliverable
    {

        int weight { get; set; }
        string address { get; set; }

        double CalculatePrice(bool fromLocker);

    }
}
