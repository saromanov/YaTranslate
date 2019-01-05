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
            llist.Output();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}