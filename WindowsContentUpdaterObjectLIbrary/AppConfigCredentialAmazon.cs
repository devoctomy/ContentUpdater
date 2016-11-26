using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class AppConfigCredentialAmazon : AppConfigCredentialBase
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

        public static AppConfigCredentialAmazon ParseJSON(JObject iJSON)
        {
            AppConfigCredentialAmazon cACAAmazon = new AppConfigCredentialAmazon();
            cACAAmazon.cStrAccessKeyID = iJSON["AccessKeyID"].Value<String>();
            cACAAmazon.cStrSecretAccessKey = iJSON["SecretAccessKey"].Value<String>();
            return (cACAAmazon);
        }

        #endregion

    }

}
