using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTest.Entity
{
    class Province
    {
        private string _Name;
        private List<string> _Childs = new List<string>();

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public List<string> Childs
        {
            get
            {
                return _Childs;
            }

            set
            {
                _Childs = value;
            }
        }
    }
}
