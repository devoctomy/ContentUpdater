using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

   public class AppConfigInfo
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

        public static AppConfigInfo ParseJSON(JObject iJSON)
        {
            AppConfigInfo cACIInfo = new AppConfigInfo();
            cACIInfo.cStrTitle = iJSON["Title"].Value<String>();
            return (cACIInfo);
        }

        #endregion

    }

}
