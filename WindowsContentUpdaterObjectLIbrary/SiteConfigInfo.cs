using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

   public class SiteConfigInfo
    {

        #region private objects

        private String cStrTitle = String.Empty;

        #endregion

        #region public properties

        public String Title
        {
            get { return (cStrTitle); }
        }

        #endregion

        #region public methods

        public static SiteConfigInfo ParseJSON(JObject iJSON)
        {
            SiteConfigInfo cACIInfo = new SiteConfigInfo();
            cACIInfo.cStrTitle = iJSON["Title"].Value<String>();
            return (cACIInfo);
        }

        #endregion

    }

}
