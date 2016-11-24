using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class ContentJSONFormatField
    {

        #region private objects

        private String cStrName = String.Empty;
        private String cStrDisplayName = String.Empty;
        private Type cTypValueType = null;
        private Object cObjValue = null;

        #endregion

        #region public properties

        public String Name
        {
            get { return (cStrName); }
        }

        public String DisplayName
        {
            get { return (cStrName); }
        }

        public Type ValueType
        {
            get { return (cTypValueType); }
        }

        public Object Value
        {
            get { return (cObjValue); }
        }

        #endregion

        #region constructor / destructor

        public ContentJSONFormatField(String iName,
            String iDisplayName,
            Type iValueType,
            Object iValue)
        {
            cStrName = iName;
            cStrDisplayName = iDisplayName;
            cTypValueType = iValueType;
            cObjValue = iValue;
        }

        #endregion

    }

}
