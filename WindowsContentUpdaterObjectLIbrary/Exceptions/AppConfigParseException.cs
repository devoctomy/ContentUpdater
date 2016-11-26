using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary.Exceptions
{

    public class AppConfigParseException : Exception
    {

        #region constructor / destructor

        public AppConfigParseException(Exception iInnerException) :
            base("An error ocurred whilst parsing the configuration JSON.", iInnerException)
        {
        }

        #endregion

    }

}
