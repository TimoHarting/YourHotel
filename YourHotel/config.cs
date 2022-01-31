using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourHotel
{
    class config
    {
        #region singleton
        private config() { }
        public static config getconfig
        {
            get
            {
                if (_getconfig == null)
                {
                    _getconfig = new config();
                }
                return _getconfig;
            }
            set
            {
                _getconfig = value;
            }
        }

        private static config _getconfig;

        #endregion

        public bool loggedin = false;
    }
}
