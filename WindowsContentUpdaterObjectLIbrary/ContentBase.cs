using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WindowsContentUpdaterObjectLibrary
{

    public class ContentBase
    {

        #region private objects

        private Dictionary<String, Object> cDicArgs;
        private MemoryStream cMSmContent = new MemoryStream();

        #endregion

        #region public properties

        protected IReadOnlyDictionary<String, Object> Args
        {
            get { return (cDicArgs); }
        }

        public String RemotePath
        {
            get { return ((String)Args["RemotePath"]); }
        }

        public String RemoteKey
        {
            get { return ((String)Args["RemoteKey"]); }
        }

        public MemoryStream Content
        {
            get { return (cMSmContent); }
        }

        #endregion

        #region constructor / destructor

        public ContentBase(Dictionary<String, Object> iArgs)
        {
            cDicArgs = iArgs;
        }

        #endregion

        #region public methods

        public virtual void ParseContent()
        {

        }

        #endregion

    }

}