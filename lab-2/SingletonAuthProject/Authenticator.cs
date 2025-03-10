using System;

namespace SingletonAuthProject
{
    public sealed class Authenticator
    {
        private static Authenticator? _instance;
        private static readonly object _lock = new object();
        private string _token;

        private Authenticator()
        {
            _token = Guid.NewGuid().ToString();
        }

        public static Authenticator GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Authenticator();
                    }
                }
            }
            return _instance;
        }

        public string GetToken() => _token;
    }
}