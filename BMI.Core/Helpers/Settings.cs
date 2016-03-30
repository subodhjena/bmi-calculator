using System;
using System.Collections.Generic;

namespace BMI.Core.Helpers
{
    public class Settings
    {
        private static readonly object mutex = new object();
        private static Settings _instance = null;

        public static Settings Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (mutex)
                    {
                        if (_instance == null)
                        {
                            _instance = new Settings();
                        }
                    }
                }
                return _instance;
            }
        }

        private  Settings()
        {
            _weightUnits = new List<string>(){ "K.G", "POUNDS" };
        }

        private IList<String> _weightUnits;

        public IList<String> WeightUnits
        {
            get { return _weightUnits; }
        }
    }
}