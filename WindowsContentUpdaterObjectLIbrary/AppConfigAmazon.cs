using Newtonsoft.Json.Linq;
using System;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class AppConfigAmazon
    {

        #region private objects

        private String cStrAccessKeyID = String.Empty;
        private String cStrSecretAccessKey = String.Empty;

        #endregion

        #region public properties

        public String AccessKeyID
        {
            get { return (cStrAccessKeyID); }
        }

        public String SecretAccessKey
        {
            get { return (cStrSecretAccessKey); }
        }

        #endregion

        #region public methods

        public static AppConfigAmazon ParseJSON(JObject iJSON)
        {
            AppConfigAmazon cACAAmazon = new AppConfigAmazon();
            cACAAmazon.cStrAccessKeyID = iJSON["AccessKeyID"].Value<String>();
            cACAAmazon.cStrSecretAccessKey = iJSON["SecretAccessKey"].Value<String>();
            return (cACAAmazon);
        }

        #endregion

    }

}
