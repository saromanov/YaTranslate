using System;
using YaTranslate.Services;

namespace YaTranslate.Core {
    public class ProgramCore : IDisposable{
        private ILanguageList llist;
        private readonly string[] args;
        internal ProgramCore(string[] args)
        {   
            this.args = args; 
        }

        public void Languages() {
            Settings settings = "123";
            var webRequest = new WebRequestFactory(settings);
            llist = new LanguageList(webRequest);
            llist.Output();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}