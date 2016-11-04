using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class PCDName
    {
        private string _name;
        private string _sname;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Sname
        {
            get
            {
                return _sname;
            }

            set
            {
                _sname = value;
            }
        }
    }
}
