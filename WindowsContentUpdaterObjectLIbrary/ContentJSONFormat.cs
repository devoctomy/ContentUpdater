using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLIbrary
{

    public class ContentJSONFormat
    {

        #region private objects

        private List<ContentJSONFormatField> cLisFields;

        #endregion

        #region public properties

        public List<ContentJSONFormatField> Fields
        {
            get { return (cLisFields); }
        }

        #endregion

        #region constructor / destructor

        public ContentJSONFormat()
        {
            cLisFields = new List<ContentJSONFormatField>();
        }

        #endregion

        #region public methods

        public static ContentJSONFormat Parse(JObject iJSON)
        {
            ContentJSONFormat pCJFFormat = new ContentJSONFormat();
            JArray pJAyFields = iJSON["Fields"].Value<JArray>();
            foreach(JObject curField in pJAyFields)
            {
                String pStrName = curField["Name"].Value<String>();
                String pStrDisplayName = curField["DisplayName"].Value<String>();
                String pStrValueType = curField["ValueType"].Value<String>();
                Type pTypValueType = Type.GetType(pStrValueType);
                pCJFFormat.cLisFields.Add(new ContentJSONFormatField(pStrName,
                    pStrDisplayName,
                    pTypValueType,
                    null));
            }
            return (pCJFFormat);
        }

        #endregion

    }

}
