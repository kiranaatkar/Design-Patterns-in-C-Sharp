namespace DesignPatternsTutorial.src.DesignPatterns.Creational.Singleton
{
    public class AppSettings
    {
        private Dictionary<string, object> _settings = new Dictionary<string, object>();

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