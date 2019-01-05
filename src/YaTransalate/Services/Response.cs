using System.Net;
using System.Net.Http;
using System.IO;

namespace YaTranslate.Services {

    public class Response {

        public Response(){}

        public bool Do(HttpWebRequest factory) {
            var response = (HttpWebResponse)factory.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return true;
        }
    }
}