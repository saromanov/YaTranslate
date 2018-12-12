using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace YaTranslate.Services {

    public class WebRequestFactory: IWebRequestFactory {
        private Settings settings;
        public WebRequestFactory(Settings settings) {
            this.settings = settings;
        }

        private HttpWebRequest CreateGetReqeust(string url, string referer = "", Dictionary<string, string> headers = null){
            var request = (HttpWebRequest)WebRequest.Create(HttpUtility.UrlDecode(url));
            request.ProtocolVersion = HttpVersion.Version11;
            request.UserAgent = settings.UserAgent;
            request.AllowAutoRedirect = true;
            request.Method = "GET";
            return request;
        }

        private HttpWebRequest CreatePostRequest(string url, string referer = "", Dictionary<string, string> headers = null) {
            var request = (HttpWebRequest)WebRequest.Create(HttpUtility.UrlDecode(url));
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers["X-Requested-With"] = "XMLHttpRequest";
            return request;
        }

        public string UrlEncode(IDictionary<string, string> parameters)
        {
            var sb = new StringBuilder();
            foreach (KeyValuePair<string, string> val in parameters)
                sb.AppendFormat("{0}={1}&", val.Key, HttpUtility.UrlEncode(val.Value));
            
            sb.Remove(sb.Length - 1, 1); // remove last '&'
            return sb.ToString();
        }
        

    }
}