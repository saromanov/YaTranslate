using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace YaTranslate.Service {

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
            request.Method = "GET"
        }
        
    }
}