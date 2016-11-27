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

    public class SiteConfig
    {

        #region rivate objects

        private SiteConfigInfo cACIInfo;
        private SiteConfigCredentials cACCCredentials;
        private JObject cJOtConfig;

        #endregion

        #region public properties


        public SiteConfigInfo Info
        {
            get { return (cACIInfo); }
        }

        public SiteConfigCredentials Credentials
        {
            get { return (cACCCredentials); }
        }

        #endregion

        #region public methods

        public static SiteConfig Parse(String iConfigJSON)
        {
            try
            {
                SiteConfig pACgParsed = new SiteConfig();
                pACgParsed.cJOtConfig = JObject.Parse(iConfigJSON);
                pACgParsed.cACIInfo = SiteConfigInfo.ParseJSON(pACgParsed.cJOtConfig["Info"].Value<JObject>());
                pACgParsed.cACCCredentials = SiteConfigCredentials.ParseJSON(pACgParsed.cJOtConfig["Credentials"].Value<JArray>());
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
