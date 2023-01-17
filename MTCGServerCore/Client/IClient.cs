using MTCGServerCore.Request;


namespace MTCGServerCore.Client
{
    public interface IClient
    {
        public RequestContext? ReceiveRequest();
        public void SendResponse(Response.Response response);
        public void Close();
    }
    
}
