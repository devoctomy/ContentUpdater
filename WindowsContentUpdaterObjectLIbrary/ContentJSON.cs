using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsContentUpdaterObjectLibrary
{

    public class ContentJSON : ContentBase
    {

        #region private objects

        private JObject cJOtContent;

        #endregion

        #region public properties

        public JObject ContentAsJSON
        {
            get { return (cJOtContent); }
        }


        #endregion

        #region constructor / destructor

        public ContentJSON(Dictionary<String, Object> iArgs) :
            base(iArgs)
        {

        }

        #endregion

        #region public methods

        public override void ParseContent()
        {
            Content.Seek(0, SeekOrigin.Begin);
            using (StreamReader pSRrContent = new StreamReader(Content))
            {
                using (JsonTextReader pJTRContent = new JsonTextReader(pSRrContent))
                {
                    cJOtContent = (JObject)JObject.ReadFrom(pJTRContent);
                }
            }             
        }

        #endregion

    }

}