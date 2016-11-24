using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsContentUpdaterObjectLibrary
{

    public class StorageEndpointBase
    {

        #region public methods

        public virtual async Task<Boolean> Get<ContentType>(ContentType iContent) where ContentType : ContentBase
        {
            throw new NotImplementedException();
        }

        public virtual async Task Put()
        {
            throw new NotImplementedException();
        }

        #endregion

    }

}