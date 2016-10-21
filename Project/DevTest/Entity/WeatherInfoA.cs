using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class WeatherInfoA
    {
        private string _ToDay;
        private string _T;
        private string _Wind;
        private Image _IconA;
        private Image _IconB;

        public string ToDay
        {
            get
            {
                return _ToDay;
            }

            set
            {
                _ToDay = value;
            }
        }

        public string T
        {
            get
            {
                return _T;
            }

            set
            {
                _T = value;
            }
        }

        public string Wind
        {
            get
            {
                return _Wind;
            }

            set
            {
                _Wind = value;
            }
        }

        public Image IconA
        {
            get
            {
                return _IconA;
            }

            set
            {
                _IconA = value;
            }
        }

        public Image IconB
        {
            get
            {
                return _IconB;
            }

            set
            {
                _IconB = value;
            }
        }
    }
}
