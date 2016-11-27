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

    [DefaultEvent("ButtonClicked")]
    [Serializable()]
    public partial class FlowLayoutButtonMenuButton : UserControl
    {

        #region public events

        public event EventHandler<EventArgs> ButtonClicked;

        #endregion

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

        #region constructor / destructor

        private void butButton_Click(object sender, EventArgs e)
        {
            if(ButtonClicked != null)
            {
                ButtonClicked(this, EventArgs.Empty);
            }
        }

        #endregion

    }

}
