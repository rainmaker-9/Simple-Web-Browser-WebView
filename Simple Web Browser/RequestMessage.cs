using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Simple_Web_Browser
{
    public static class RequestMessage
    {
        public static HttpWebResponse GetHttpWebResponse(Uri uri)
        {
            try
            {
                HttpWebResponse response = null;
                bool result = Uri.TryCreate(uri.OriginalString, UriKind.Absolute, out Uri uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if (result)
                {
                    HttpWebRequest request = WebRequest.CreateHttp(uriResult);
                    response = (HttpWebResponse)request.GetResponse();
                }
                return response;
            }
            catch (WebException ex)
            {
                return (HttpWebResponse)ex.Response;
            }
        }

        public static ResponseMessage GetResponseMessage(Uri uri)
        {
            ResponseMessage responseMessage = null;
            try
            {
                HttpWebResponse response = null;
                bool result = Uri.TryCreate(uri.OriginalString, UriKind.Absolute, out Uri uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                if (result)
                {
                    HttpWebRequest request = WebRequest.CreateHttp(uriResult);
                    response = (HttpWebResponse)request.GetResponse();
                    using StreamReader streamReader = new StreamReader(response.GetResponseStream());
                    responseMessage = new ResponseMessage()
                    {
                        ContentLength = streamReader.ReadToEnd().Length,
                        StatusCode = response.StatusCode,
                    };
                }
                return responseMessage;
            }
            catch (WebException ex)
            {
                HttpWebResponse error = (HttpWebResponse)ex.Response;
                using StreamReader streamReader = new StreamReader(error.GetResponseStream());
                responseMessage = new ResponseMessage()
                {
                    ContentLength = streamReader.ReadToEnd().Length,
                    StatusCode = error.StatusCode,
                };
                return responseMessage;
            }
        }

        public static async Task<string> Test(Uri uri)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync(uri);
            return result;
        }
    }
}
