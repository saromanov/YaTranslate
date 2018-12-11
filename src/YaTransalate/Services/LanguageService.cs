namespace YaTranslate.Services {

    public class LanguageList: ILanguageList {
        private readonly IWebRequestFactory factory;
        private readonly String endpoint = "https://translate.yandex.net/api/v1.5/tr.json/getLangs";


        public LanguageList(IWebRequestFactory factory){
            this.factory = factory;
        }

        public async Task GetLanguages(){
            try
            {
                await getLanguagesRequest():
            }
            catch (TimeoutException)
            {
            }
        }

        public void getLanguagesRequest(){
            var response = factory.CreatePostRequest(endpoint);
        }
    }
}