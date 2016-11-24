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
using WindowsContentUpdaterObjectLibrary;
using WindowsContentUpdaterObjectLIbrary;

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

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    String pStrConfig = File.ReadAllText(@"C:\Temp\contentupdater.thecrownsportsbar.creds");
        //    AppConfig pACgConfig = AppConfig.Parse(pStrConfig);

        //    Dictionary<String, Object> pDicArgs = new Dictionary<String, Object>();
        //    pDicArgs.Add("RemotePath", "www.thecrownsportsbar.co.uk");
        //    pDicArgs.Add("RemoteKey", "cu/content/test.json");
        //    ContentJSON pCJnJSON = new ContentJSON(pDicArgs);

        //    S3StorageEndpoint pSSEContent = new S3StorageEndpoint(pACgConfig.AccessKeyID,
        //        pACgConfig.SecretAccessKey);

        //    Boolean pBlnSuccess = await pSSEContent.Get<ContentJSON>(pCJnJSON);
        //}

        #region object events

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JObject pJOrFormat = JObject.Parse(File.ReadAllText(@"C:\devoctomy\GitHub\ContentUpdater\WindowsContentUpdater\bin\Debug\Assets\Templates\DartsLeague.json"));
            ContentJSONFormat pop = ContentJSONFormat.Parse(pJOrFormat);

            Close();
        }

        #endregion

    }

}
