using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class AppConfigCredentials
    {

        #region private objects

        private Dictionary<String, AppConfigCredentialBase> cLisCredentials;

        #endregion

        #region public properties

        public IReadOnlyDictionary<String, AppConfigCredentialBase> Credentials
        {
            get { return (cLisCredentials); }
        }

        #endregion

        #region constructor / destructor

        public AppConfigCredentials()
        {
            cLisCredentials = new Dictionary<String, AppConfigCredentialBase>();
        }

        #endregion

        #region public methods

        public static AppConfigCredentials ParseJSON(JArray iJSON)
        {
            AppConfigCredentials pACCCreds = new AppConfigCredentials();
            foreach (JObject curCredential in iJSON)
            {
                String pStrCredType = curCredential["CredentialType"].Value<String>();
                switch (pStrCredType)
                {
                    case "Amazon":
                        {
                            AppConfigCredentialAmazon pACCAmazon = AppConfigCredentialAmazon.ParseJSON(curCredential);
                            pACCCreds.cLisCredentials.Add(curCredential["Name"].Value<String>(), pACCAmazon);
                            break;
                        }
                    default:
                        {
                            //Unknown credential type
                            break;
                        }
                }
            }
            return (pACCCreds);
        }

        #endregion

    }

}
