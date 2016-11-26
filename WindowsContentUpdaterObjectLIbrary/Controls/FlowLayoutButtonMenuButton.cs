using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsContentUpdaterObjectLIbrary.Controls
{

    [Serializable()]
    public partial class FlowLayoutButtonMenuButton : UserControl
    {

        #region public properties

        public String ButtonText
        {
            get { return (butButton.Text); }
            set { butButton.Text = value; }
        }

        public Image ButtonImage
        {
            get { return (butButton.Image); }
            set { butButton.Image = value; }
        }

        #endregion

        #region constructor / destructor

        public FlowLayoutButtonMenuButton()
        {
            InitializeComponent();
        }

        #endregion

    }

}
