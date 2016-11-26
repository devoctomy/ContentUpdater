using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsContentUpdaterObjectLIbrary.Exceptions;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class AppConfig
    {

        #region rivate objects

        private AppConfigInfo cACIInfo;
        private AppConfigCredentials cACCCredentials;
        private JObject cJOtConfig;

        #endregion

        #region public properties


        public AppConfigInfo Info
        {
            get { return (cACIInfo); }
        }

        public AppConfigCredentials Credentials
        {
            get { return (cACCCredentials); }
        }

        #endregion

        #region public methods

        public static AppConfig Parse(String iConfigJSON)
        {
            try
            {
                AppConfig pACgParsed = new AppConfig();
                pACgParsed.cJOtConfig = JObject.Parse(iConfigJSON);
                pACgParsed.cACIInfo = AppConfigInfo.ParseJSON(pACgParsed.cJOtConfig["Info"].Value<JObject>());
                pACgParsed.cACCCredentials = AppConfigCredentials.ParseJSON(pACgParsed.cJOtConfig["Credentials"].Value<JArray>());
                return (pACgParsed);
            }
            catch (Exception ex)
            {
                throw new AppConfigParseException(ex);
            }
        }

        #endregion

    }

}
