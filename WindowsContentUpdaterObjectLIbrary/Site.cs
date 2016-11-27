using System;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class Site
    {

        #region private objects

        private SiteConfig cSCgConfig;

        #endregion

        #region public properties

        public SiteConfig Config
        {
            get { return (cSCgConfig); }
        }

        #endregion

        #region constructor / destructor

        public static Site Parse(String iAppConfigJSON)
        {
            Site pSitSite = new Site();
            pSitSite.cSCgConfig = SiteConfig.Parse(iAppConfigJSON);
            return (pSitSite);
        }

        #endregion

    }

}
