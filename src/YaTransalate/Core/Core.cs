using System;
using YaTranslate.Services;

namespace YaTranslate.Core {
    public class ProgramCore : IDisposable{
        private ArgumentParser parser;
        internal ProgramCore(string[] args)
        {   
            parser = new ArgumentParser(args);
        }

        public void Execute() {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}