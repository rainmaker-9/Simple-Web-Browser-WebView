using System.Net;

namespace Simple_Web_Browser
{
    public class ResponseMessage
    {
        public HttpStatusCode StatusCode { get; set; }
        public long ContentLength { get; set; }
    }
}
