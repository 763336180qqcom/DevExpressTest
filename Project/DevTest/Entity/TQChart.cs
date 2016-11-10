using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class TQChart
    {
        private string _Tmpmax;
        private string _Tmpmin;
        private string _Hum;
        private string _Vis;

        public string Tmpmax
        {
            get
            {
                return _Tmpmax;
            }

            set
            {
                _Tmpmax = value;
            }
        }

        public string Tmpmin
        {
            get
            {
                return _Tmpmin;
            }

            set
            {
                _Tmpmin = value;
            }
        }

        public string Hum
        {
            get
            {
                return _Hum;
            }

            set
            {
                _Hum = value;
            }
        }

        public string Vis
        {
            get
            {
                return _Vis;
            }

            set
            {
                _Vis = value;
            }
        }
    }
}
