using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo07
{
    public enum GradeEnum
    {
        Elégtelen,
        Elégséges,
        Közepes,
        Jó,
        Jeles
    }
    public class ExamResult
    {
        private string _neptunKod;
        private int _zhPontszam;
        private GradeEnum _grade;

        public string NeptunKod
        {
            get { return _neptunKod; }
            private set 
            {
                if (value.Length == 6)
                {
                    _neptunKod = value;
                }

                else
                {
                    throw new NemMegfeleloHosszuNeptunKod("HIBA!!! 6 karakterből álló neptunkódot adj meg.");
                }
            }
        }

        public int ZhPontszam
        {
            get
            {
                return _zhPontszam;
            }

            set
            {
                _zhPontszam = value;
            }
        }

        public bool Passed
        {
            get
            {
                if (ZhPontszam >= 50)
                {
                    return true;
                } 

                else
                {
                    return false;
                }
            }
        }

        public GradeEnum Grade(int[] ponthatarok)
        {
            if (ZhPontszam < ponthatarok[1])
            {
                return GradeEnum.Elégtelen;
            }

            else if (ZhPontszam >= ponthatarok[1] && ZhPontszam < ponthatarok[2])
            {
                return GradeEnum.Elégséges;
            }

            else if (ZhPontszam >= ponthatarok[2] && ZhPontszam < ponthatarok[3])
            {
                return GradeEnum.Közepes;
            }

            else if (ZhPontszam >= ponthatarok[3] && ZhPontszam < ponthatarok[4])
            {
                return GradeEnum.Jó;
            }

            else
            {
                return GradeEnum.Jeles;
            }
        }

        public ExamResult(string neptunKod, int zhPontszam)
        {
            NeptunKod = neptunKod;
            ZhPontszam = zhPontszam;
        }

        public ExamResult()
        {
            Random rnd = new Random();
            ZhPontszam = rnd.Next(0, 101);
            string tmpNeptunKod = "";
            for (int i = 0; i < 6; i++)
            {
                int numberOrLetter = rnd.Next(0, 1);

                if (numberOrLetter == 0)
                {
                    tmpNeptunKod += (char)rnd.Next('A', ('Z' + 1));
                }

                else
                {
                    tmpNeptunKod += rnd.Next(0, 10);
                }
            }

            NeptunKod = tmpNeptunKod;
        }



    }
}
