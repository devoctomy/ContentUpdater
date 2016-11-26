using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace WindowsContentUpdaterObjectLIbrary.Controls
{

    public partial class FlowLayoutButtonMenu : UserControl
    {

        #region private objects

        private ObservableCollection<FlowLayoutButtonMenuButton> cOCnButtons;

        #endregion

        #region public properties

        [Category("Data")]
        [Description("Collection of buttons to be displayed by the menu.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<FlowLayoutButtonMenuButton> Buttons
        {
            get { return (cOCnButtons); }
        }

        #endregion

        #region constructor / destructor

        public FlowLayoutButtonMenu()
        {
            InitializeComponent();
            cOCnButtons = new ObservableCollection<FlowLayoutButtonMenuButton>();
            cOCnButtons.CollectionChanged += COCnButtons_CollectionChanged;
        }

        #endregion

        #region private methods

        private void ResetControls()
        {
            flpLayout.Controls.Clear();
            foreach (FlowLayoutButtonMenuButton curButton in Buttons)
            {
                curButton.Width = Width - 32;       //Need to calculate this dynamically
                flpLayout.Controls.Add(curButton);
            }
        }

        #endregion

        #region object events

        private void COCnButtons_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch(e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    {
                        foreach(Control curControl in e.NewItems)
                        {
                            curControl.Width = Width - 32; //Need to calculate this dynamically
                            flpLayout.Controls.Add(curControl);
                        }
                        break;
                    }
            }
        }

        #endregion

    }

}
