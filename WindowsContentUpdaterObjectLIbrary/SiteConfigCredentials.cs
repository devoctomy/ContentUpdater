using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class SiteConfigCredentials
    {

        #region private objects

        private ObservableCollection<SiteConfigCredentialBase> cOCnCredentials;

        #endregion

        #region public properties

        public ObservableCollection<SiteConfigCredentialBase> Credentials
        {
            get { return (cOCnCredentials); }
        }

        #endregion

        #region constructor / destructor

        public SiteConfigCredentials()
        {
            cOCnCredentials = new ObservableCollection<SiteConfigCredentialBase>();
        }

        #endregion

        #region public methods

        public static SiteConfigCredentials ParseJSON(JArray iJSON)
        {
            SiteConfigCredentials pACCCreds = new SiteConfigCredentials();
            foreach (JObject curCredential in iJSON)
            {
                String pStrCredType = curCredential["CredentialType"].Value<String>();
                switch (pStrCredType)
                {
                    case "Amazon":
                        {
                            SiteConfigCredentialAmazon pACCAmazon = SiteConfigCredentialAmazon.ParseJSON(curCredential);
                            pACCCreds.cOCnCredentials.Add(pACCAmazon);
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
