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

        public static Site LoadSite(String iFullPath)
        {
            String pStrSiteConfigPath = iFullPath;
            String pStrSiteConfigJSON = File.ReadAllText(pStrSiteConfigPath);
            Site pSitSite = Site.Parse(pStrSiteConfigJSON);
            return (pSitSite);
        }

        #endregion

    }

}
