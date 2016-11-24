using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class AppConfig
    {

        #region rivate objects

        private JObject cJOtConfig;

        #endregion

        #region public properties

        public String AccessKeyID { get; private set; }

        public String SecretAccessKey { get; private set; }

        #endregion

        #region public methods

        public static AppConfig Parse(String iConfig)
        {
            AppConfig pACgParsed = new AppConfig();
            pACgParsed.cJOtConfig = JObject.Parse(iConfig);
            pACgParsed.AccessKeyID = pACgParsed.cJOtConfig["AccessKeyID"].Value<String>();
            pACgParsed.SecretAccessKey = pACgParsed.cJOtConfig["SecretAccessKey"].Value<String>();
            return (pACgParsed);
        }

        #endregion

    }

}
