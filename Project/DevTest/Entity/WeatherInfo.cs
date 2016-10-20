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
        private string _Tm;

        private string _Date0;
        private string _IconName0A;
        private string _IconName0B;
        private string _Wind0;
        private string _T0;

        private string _Date1;
        private string _IconName1A;
        private string _IconName1B;
        private string _Wind1;
        private string _T1;

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
        public string Date0
        {
            get
            {
                return _Date0;
            }

            set
            {
                _Date0 = value;
            }
        }

        public string IconName0A
        {
            get
            {
                return _IconName0A;
            }

            set
            {
                _IconName0A = value;
            }
        }

        public string IconName0B
        {
            get
            {
                return _IconName0B;
            }

            set
            {
                _IconName0B = value;
            }
        }

        public string Wind0
        {
            get
            {
                return _Wind0;
            }

            set
            {
                _Wind0 = value;
            }
        }

        public string T0
        {
            get
            {
                return _T0;
            }

            set
            {
                _T0 = value;
            }
        }

        public string Date1
        {
            get
            {
                return _Date1;
            }

            set
            {
                _Date1 = value;
            }
        }

        public string IconName1A
        {
            get
            {
                return _IconName1A;
            }

            set
            {
                _IconName1A = value;
            }
        }

        public string IconName1B
        {
            get
            {
                return _IconName1B;
            }

            set
            {
                _IconName1B = value;
            }
        }

        public string Wind1
        {
            get
            {
                return _Wind1;
            }

            set
            {
                _Wind1 = value;
            }
        }

        public string T1
        {
            get
            {
                return _T1;
            }

            set
            {
                _T1 = value;
            }
        }


        public override string ToString()
        {
            return "位置:" + City +" "+"时间："+Tm+ " " + "今日：" + Date0 + " " + IconName0A + "~" + IconName0B + " " + Wind0 + " " + "气温：" + T0;
        }
    }
}
