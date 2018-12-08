using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace YaTranslate.Service {

    public class WebRequestFactory: IWebRequestFactory {
        public WebRequestFactory() {

        }

        private HttpWebRequest CreateGetReqeust(string url, string referer = "", Dictionary<string, string> headers = null){
            var request = (HttpWebRequest)WebRequest.Create(HttpUtility.UrlDecode(url));
            request.ProtocolVersion = HttpVersion.Version11;
            request.UserAgent = settings.UserAgent;
            request.AllowAutoRedirect = true;
            request.Method = "GET"
        }
    }
}