using System;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class Site
    {

        #region private objects

        private AppConfig cACgConfig;

        #endregion

        #region constructor / destructor

        public static Site Parse(String iAppConfigJSON)
        {
            Site pSitSite = new Site();
            pSitSite.cACgConfig = AppConfig.Parse(iAppConfigJSON);
            return (pSitSite);
        }

        #endregion

    }

}
