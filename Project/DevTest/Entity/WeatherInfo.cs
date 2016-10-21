using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class WeatherInfo
    {
        private string _City;
        private string _Area;
        private string _Tm;
        private string _ToDay;
        private string _Uv;
        private string _UvIndex;
        private List<WeatherInfoA> weather5Days=new List<WeatherInfoA>(); 

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string Area
        {
            get
            {
                return _Area;
            }

            set
            {
                _Area = value;
            }
        }

        public string Tm
        {
            get
            {
                return _Tm;
            }

            set
            {
                _Tm = value;
            }
        }

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

        public string Uv
        {
            get
            {
                return _Uv;
            }

            set
            {
                _Uv = value;
            }
        }

        public string UvIndex
        {
            get
            {
                return _UvIndex;
            }

            set
            {
                _UvIndex = value;
            }
        }

        internal List<WeatherInfoA> Weather5Days
        {
            get
            {
                return weather5Days;
            }

            set
            {
                weather5Days = value;
            }
        }
    }
}
