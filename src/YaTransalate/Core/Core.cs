using System;
using YaTranslate.Services;

namespace YaTranslate.Core {
    public class ProgramCore : IDisposable{
        private readonly ILanguageList llist;
        private readonly string[] args;
        internal ProgramCore(string[] args)
        {   
            this.args = args; 
        }

        public void Languages() {
            var webRequest = new WebRequestFactory(new Settings{
                Token= "123",
            });
            llist = new LanguageList(webRequest);
            llist.Output();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}