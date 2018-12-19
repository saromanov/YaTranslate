using System;
using YaTranslate.Services;

namespace YaTranslate.Core {
    public class ProgramCore : IDisposable{
        private llist ILanguageList;
        internal ProgramCore(string[] args)
        {   
            llist = new LanguageList();
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