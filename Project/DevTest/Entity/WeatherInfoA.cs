using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class WeatherInfoA : IDisposable
    {
        public void Dispose()
        {
            if (_DayP != null)
            {
                _DayP.Dispose();
                _DayP = null;
            }
            if (_Nightp != null)
            {
                _Nightp.Dispose();
                _Nightp = null;
            }
        }

        private string _Date;
        private Image _DayP;
        private Image _Nightp;
        private string _Weather;
        private string _Wind;
        private string _Temperature;
        private string _Sunrise;
        private string _Sunset;

        public string Date
        {
            get
            {
                return _Date;
            }

            set
            {
                _Date = value;
            }
        }

        public Image DayP
        {
            get
            {
                return _DayP;
            }

            set
            {
                _DayP = value;
            }
        }

        public Image Nightp
        {
            get
            {
                return _Nightp;
            }

            set
            {
                _Nightp = value;
            }
        }

        public string Weather
        {
            get
            {
                return _Weather;
            }

            set
            {
                _Weather = value;
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

        public string Temperature
        {
            get
            {
                return _Temperature;
            }

            set
            {
                _Temperature = value;
            }
        }

        public string Sunrise
        {
            get
            {
                return _Sunrise;
            }

            set
            {
                _Sunrise = value;
            }
        }

        public string Sunset
        {
            get
            {
                return _Sunset;
            }

            set
            {
                _Sunset = value;
            }
        }
    }
}
