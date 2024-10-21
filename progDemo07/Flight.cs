using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progDemo07
{
    public enum statusz
    {
        Scheduled,
        Delayed,
        Canceled
    }
    public class Flight
    {
        private string _jaratSzam;
        private string _celallomas;
        private DateTime _indulasIdopont;
        private int _kesesPercben;
        private statusz _gepStatusz;

        public Flight(string jaratSzam, string celallomas, DateTime indulasIdopont, int kesesPercben)
        {
            _jaratSzam = jaratSzam;
            _celallomas = celallomas;
            _indulasIdopont = indulasIdopont;
            _kesesPercben = kesesPercben;
            UpdateStatusz();
        }

        public string JaratSzam
        {
            get { return _jaratSzam; }
        }
        public string Celallomas
        {
            get { return _celallomas; }
        }

        public DateTime IndulasIdopont
        {
            get { return _indulasIdopont; }
        }

        public int KesesPercben
        {
            get { return _kesesPercben; }
        }

        public statusz GepStatusz
        {
            get { return _gepStatusz; }
        }

        public void Delay(int kesesPercben)
        {
            _kesesPercben = kesesPercben;
            UpdateStatusz();
        }

        public void Cancel()
        {
            UpdateStatusz(statusz.Canceled);
        }

        private void UpdateStatusz(statusz statusz)
        {
            _gepStatusz = statusz;
        }

        private void UpdateStatusz()
        {
            if (_kesesPercben > 0)
            {
                _gepStatusz = statusz.Delayed;
            }
            
            else
            {
                _gepStatusz = statusz.Scheduled;
            }
        }

        public string AllData()
        {
            if (_gepStatusz == statusz.Canceled)
            {
                return $"Flight {_jaratSzam} is canceled.";
            }

            else
            {
                if (_kesesPercben == 0)
                {
                    return $"Flight {_jaratSzam} is on time. ({EstimatedDeparture()})";
                }

                else
                {
                    return $"Flight {_jaratSzam} is delayed by {_kesesPercben} minutes. {EstimatedDeparture()}";
                }
            }
        }

        private DateTime EstimatedDeparture()
        {
            return _indulasIdopont.AddMinutes(_kesesPercben);
        }
    }
}