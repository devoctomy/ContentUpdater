using System;
using System.Threading.Tasks;
using Amazon.S3.Model;
using System.IO;
using Amazon.S3;

namespace WindowsContentUpdaterObjectLibrary
{

    public class S3StorageEndpoint : StorageEndpointBase
    {


        #region private objects

        AmazonS3Client cACtClient;

        #endregion

        #region constructor / destructor

        public S3StorageEndpoint(String iAccessKeyID, 
            String iSecretAccessKey)
        {
            cACtClient = new AmazonS3Client(iAccessKeyID, 
                iSecretAccessKey, 
                Amazon.RegionEndpoint.USEast1);
        }

        #endregion

        #region public methods


        public override async Task<Boolean> Get<ContentType>(ContentType iContent)
        {
            GetObjectResponse pGORGetResponse = await cACtClient.GetObjectAsync(iContent.RemotePath,
                iContent.RemoteKey);
            if (pGORGetResponse.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                using (Stream pStmGetResponse = pGORGetResponse.ResponseStream)
                {
                    await pStmGetResponse.CopyToAsync(iContent.Content);
                    iContent.ParseContent();
                    return (true);
                }
            }
            else
            {
                return (false);
            }
        }

        public override async Task Put()
        {
            await Task.Delay(0);        //Put simply to remove compiler warning
        }

        #endregion

    }

}