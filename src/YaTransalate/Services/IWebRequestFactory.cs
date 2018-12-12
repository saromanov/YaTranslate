using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace YaTranslate.Services
{
    public interface IWebRequestFactory
    {
        HttpWebRequest CreateGetReqeust(string url, string referer = "", Dictionary<string, string> headers = null);

        HttpWebRequest CreatePostReqeust(string url, string referer = "", Dictionary<string, string> headers = null);

        Task CreatePostReqeustAsync(HttpWebRequest request, Dictionary<string, string> parameters);

    }
}