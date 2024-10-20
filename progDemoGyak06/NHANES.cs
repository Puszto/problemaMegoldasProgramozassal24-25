using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemoGyak06
{
    public class NHANES
    {
        public int _SEQN;
        public string _SURVEY;
        public double _RIAGENDR;
        public double _RIDAGEYR;
        public double _BMXBMI;
        public double _LBDGLUSI;

        public NHANES(int sEQN, string sURVEY, double rIAGENDR, double rIDAGEYR, double bMXBMI, double lBDGLUSI)
        {
            _SEQN = sEQN;
            _SURVEY = sURVEY;
            _RIAGENDR = rIAGENDR;
            _RIDAGEYR = rIDAGEYR;
            _BMXBMI = bMXBMI;
            _LBDGLUSI = lBDGLUSI;
        }


    }
}
