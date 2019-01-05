namespace YaTranslate.Services {

    public struct Settings {
        public string Token {get;set;}

        public static implicit operator Settings(string token) {
            return new Settings() { Token = token };
        }
    } 
}