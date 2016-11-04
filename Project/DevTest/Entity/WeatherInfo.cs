using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class WeatherInfo
    {
        private string _City;//当前位置
        private string _Indicator;
        private List<WeatherInfoA> weather4Days = new List<WeatherInfoA>();

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

        internal List<WeatherInfoA> Weather4Days
        {
            get
            {
                return weather4Days;
            }

            set
            {
                weather4Days = value;
            }
        }

        public string ZhiShu
        {
            get
            {
                return _Indicator;
            }

            set
            {
                _Indicator = value;
            }
        }
    }
}
