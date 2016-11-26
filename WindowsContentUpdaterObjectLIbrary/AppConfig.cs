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

        private static AppConfig cACgCurrent;
        private AppConfigInfo cACIInfo;
        private AppConfigAmazon cACAAmazon;
        private JObject cJOtConfig;

        #endregion

        #region public properties

        public static AppConfig Current
        {
            get { return (cACgCurrent); }
        }

        public AppConfigInfo Info
        {
            get { return (cACIInfo); }
        }

        public AppConfigAmazon Amazon
        {
            get { return (cACAAmazon); }
        }

        #endregion

        #region public methods

        public static AppConfig InitCurrent(String iConfig)
        {
            try
            {
                AppConfig pACgParsed = new AppConfig();
                pACgParsed.cJOtConfig = JObject.Parse(iConfig);
                pACgParsed.cACIInfo = AppConfigInfo.ParseJSON(pACgParsed.cJOtConfig["Info"].Value<JObject>());
                pACgParsed.cACAAmazon = AppConfigAmazon.ParseJSON(pACgParsed.cJOtConfig["Amazon"].Value<JObject>());
                cACgCurrent = pACgParsed;
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
