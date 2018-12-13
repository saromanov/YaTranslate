using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace YaTranslate.Services
{
    public interface IWebRequestFactory
    {
        HttpWebRequest CreateGetRequest(string url, string referer = "", Dictionary<string, string> headers = null);

        HttpWebRequest CreatePostRequest(string url, string referer = "", Dictionary<string, string> headers = null);

        Task<bool> CreatePostRequestAsync(HttpWebRequest request, Dictionary<string, string> parameters);

    }
}