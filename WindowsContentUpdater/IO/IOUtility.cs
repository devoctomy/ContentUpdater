using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsContentUpdaterObjectLIbrary;
using WindowsContentUpdaterObjectLIbrary.Exceptions;

namespace WindowsContentUpdater.IO
{

    public class IOUtility
    {

        #region public methods

        public static void LoadDefaultAppConfig()
        {
            if (File.Exists(Properties.Settings.Default.SiteConfigPath))
            {
                IOUtility.InitAppConfig(Properties.Settings.Default.SiteConfigPath, false);
            }
        }

        public static void InitAppConfig(String iFullPath,
            Boolean iSetAsDefault)
        {
            try
            {
                String pStrSiteConfigPath = iFullPath;
                String pStrSiteConfigJSON = File.ReadAllText(pStrSiteConfigPath);
                AppConfig.InitCurrent(pStrSiteConfigJSON);
                if(iSetAsDefault)
                {
                    Properties.Settings.Default.SiteConfigPath = pStrSiteConfigPath;
                }
            }
            catch (AppConfigParseException acpex)
            {
                MessageBox.Show(acpex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }

}
