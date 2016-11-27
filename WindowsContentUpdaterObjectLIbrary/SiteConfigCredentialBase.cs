using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class SiteConfigCredentialBase
    {

        #region private objects

        private String cStrName = String.Empty;

        #endregion

        #region public properties

        public String Name
        {
            get { return (cStrName); }
        }

        #endregion

        #region constructor / destructor

        public SiteConfigCredentialBase(String iName)
        {
            cStrName = iName;
        }

        #endregion

    }

}
