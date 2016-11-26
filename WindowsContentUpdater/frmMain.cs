using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsContentUpdater.IO;
using WindowsContentUpdaterObjectLibrary;
using WindowsContentUpdaterObjectLIbrary;
using WindowsContentUpdaterObjectLIbrary.Exceptions;

namespace WindowsContentUpdater
{

    public partial class frmMain : Form
    {

        #region constructor / destructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion

        #region base class overrides

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            IOUtility.LoadDefaultAppConfig();
        }

        #endregion


        #region object events

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void siteConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog pOFDOpenSiteConfig = new OpenFileDialog())
            {
                pOFDOpenSiteConfig.AddExtension = true;
                pOFDOpenSiteConfig.AutoUpgradeEnabled = true;
                pOFDOpenSiteConfig.CheckFileExists = true;
                pOFDOpenSiteConfig.CheckPathExists = true;
                pOFDOpenSiteConfig.Filter = "Configuration files (*.config)|*.config|All files (*.*)|*.*";
                pOFDOpenSiteConfig.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                pOFDOpenSiteConfig.Multiselect = false;
                pOFDOpenSiteConfig.Title = "Browse for Site Configuration File...";
                if(pOFDOpenSiteConfig.ShowDialog() == DialogResult.OK)
                {
                    IO.IOUtility.InitAppConfig(pOFDOpenSiteConfig.FileName, true);
                }
            }
        }

        #endregion


    }

}
