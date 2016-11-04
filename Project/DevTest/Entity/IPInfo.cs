using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class IPInfo
    {

        private string _country;
        private string _province;
        private string _city;
        private string _county;
        private string _isp;
        private string _ip;

        public string _国家
        {
            get
            {
                return _country;
            }

            set
            {
                _country = value;
            }
        }


        public string _省
        {
            get
            {
                return _province;
            }

            set
            {
                _province = value;
            }
        }

        public string _市
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string _运营商
        {
            get
            {
                return _isp;
            }

            set
            {
                _isp = value;
            }
        }

        public string _区
        {
            get
            {
                return _county;
            }

            set
            {
                _county = value;
            }
        }

        public string _网络IP
        {
            get
            {
                return _ip;
            }

            set
            {
                _ip = value;
            }
        }
    }
}
