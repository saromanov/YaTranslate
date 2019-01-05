using System;
using System.Threading;
using System.Threading.Tasks;

namespace YaTranslate.Services {

    public class LanguageList: ILanguageList, IOutput {
        private IWebRequestFactory factory;
        private string endpoint = "https://translate.yandex.net/api/v1.5/tr.json/getLangs";

        public LanguageList(IWebRequestFactory factory){
            this.factory = factory;
        }

        public async void getLanguages(){
            try
            {
                await getLanguagesRequest();
            }
            catch (TimeoutException)
            {
            }
        }

        public async Task<string> getLanguagesRequest(){
            var response = factory.CreatePostRequest(endpoint);
            return "";
        }

        public string[] GetLanguages(){
            var webRequest = this.factory.CreatePostRequest(this.endpoint);
            var response = new Response().Do(webRequest);
            return new string[0];
        }

        public void Output(){
            Console.WriteLine("List of supported languages");
        }
    }
}