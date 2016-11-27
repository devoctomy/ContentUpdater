using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsContentUpdaterObjectLIbrary;

namespace WindowsContentUpdater.Forms.Controls
{
    public partial class SiteCredentials : UserControl
    {

        #region private objects

        private SiteConfigCredentials cSCICredentials;

        #endregion

        #region public properties

        public SiteConfigCredentials Credentials
        {
            get { return (cSCICredentials); }
            set { SetSiteCredentials(value); }
        }

        #endregion

        #region constructor / destructor

        public SiteCredentials()
        {
            InitializeComponent();
        }

        #endregion

        #region private methods

        private void SetSiteCredentials(SiteConfigCredentials iSiteCredentials)
        {
            cSCICredentials = iSiteCredentials;
            lbxAllCredentials.DataSource = Credentials.Credentials;
            lbxAllCredentials.DisplayMember = "Name";
        }

        #endregion

    }
}
