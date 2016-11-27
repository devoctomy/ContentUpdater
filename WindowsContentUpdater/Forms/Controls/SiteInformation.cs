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

    public partial class SiteInformation : UserControl
    {

        #region private objects

        private SiteConfigInfo cSCIInfo;

        #endregion

        #region public properties

        public SiteConfigInfo Info
        {
            get { return (cSCIInfo); }
            set { SetSiteInfo(value); }
        }

        #endregion

        #region constructor / destructor

        public SiteInformation()
        {
            InitializeComponent();
        }

        #endregion

        #region private methods

        private void SetSiteInfo(SiteConfigInfo iSiteInfo)
        {
            cSCIInfo = iSiteInfo;
            tbxTitle.DataBindings.Clear();
            Binding pBinBinding = new Binding("Text", Info, "Title");
            tbxTitle.DataBindings.Add(pBinBinding);
        }

        #endregion

    }

}
