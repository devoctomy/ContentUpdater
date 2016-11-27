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
            await Task.Delay(0);        //Put simply to remove compiler warning
            throw new NotImplementedException();
        }

        public virtual async Task Put()
        {
            await Task.Delay(0);        //Put simply to remove compiler warning
            throw new NotImplementedException();
        }

        #endregion

    }

}