using Grpc.Core;

namespace FileTransfer.Server.Services
{
    public class UploaderService : Uploader.UploaderBase
    {
        public override async Task<UploaderReply> UploadFile(IAsyncStreamReader<UploaderRequest> requestStream, ServerCallContext context)
        {
            await foreach (var item in requestStream.ReadAllAsync())
            {
                
            }
            return null;
        }
    }
}
