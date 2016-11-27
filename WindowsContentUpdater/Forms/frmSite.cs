using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsContentUpdater.Forms.Controls;
using WindowsContentUpdaterObjectLIbrary;

namespace WindowsContentUpdater.Forms
{

    public partial class frmSite : Form
    {

        #region private objects

        private Site cSitSite;
        private Dictionary<String, Control> cDicPanels;
        private Control cConLastSelectedPanel;

        #endregion

        #region public properties

        public Site _Site
        {
            get { return (cSitSite); }
        }

        #endregion

        #region constructor / destructor

        public frmSite(Site iSite)
        {
            InitializeComponent();
            cDicPanels = new Dictionary<String, Control>();
            cSitSite = iSite;
            SetupPanels();
        }

        #endregion

        #region private mathods

        private void SetupPanels()
        {
            SiteInformation pSInInfo = new SiteInformation();
            pSInInfo.Info = cSitSite.Config.Info;
            pSInInfo.Dock = DockStyle.Fill;
            scrSite.Panel2.Controls.Add(pSInInfo);
            cDicPanels.Add("info", pSInInfo);

            SiteCredentials pSCsCredentials = new SiteCredentials();
            pSCsCredentials.Credentials = cSitSite.Config.Credentials;
            pSCsCredentials.Dock = DockStyle.Fill;
            scrSite.Panel2.Controls.Add(pSCsCredentials);
            cDicPanels.Add("credentials", pSCsCredentials);
        }


        private void SelectPanel(String iKey)
        {
            if(cConLastSelectedPanel != null)
            {
                cConLastSelectedPanel.Hide();
            }
            cConLastSelectedPanel = cDicPanels[iKey];
            cConLastSelectedPanel.Show();
        }

        #endregion

        #region object events

        private void flbInformation_ButtonClicked(object sender, EventArgs e)
        {
            SelectPanel("info");
        }

        private void flbCredentials_ButtonClicked(object sender, EventArgs e)
        {
            SelectPanel("credentials");
        }

        #endregion

    }

}
