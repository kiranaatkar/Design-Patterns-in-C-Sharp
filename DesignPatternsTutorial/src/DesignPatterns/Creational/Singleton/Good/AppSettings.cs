namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Singleton.Good
{
    public class AppSettings
    {
        private static AppSettings _instance;
        private Dictionary<string, object> _settings = new Dictionary<string, object>();
        private AppSettings()
        {
        }

        public static AppSettings GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppSettings();
            }
            return _instance;
        }

        public object Get(string key)
        {
            if (_settings.ContainsKey(key))
            {
                return _settings[key];
            }
            return null;
        }

        public void Set(string key, object value)
        {
            if (_settings.ContainsKey(key))
            {
                _settings[key] = value;
            }
            else
            {
                _settings.Add(key, value);
            }
        }
    }
}