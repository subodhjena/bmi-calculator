using System;
using System.Collections.Generic;

namespace BMI.Core.Helpers
{
    public sealed class Settings
    {
        private static Settings instance = null;
        private static readonly object padlock = new object();

        IList<String> _weightUnits;

        public IList<String> WeightUnits
        {
            get { return _weightUnits; }
            set { _weightUnits = value; }
        }

        Settings()
        {
            _weightUnits = new List<string>()
            {
                "K.G",
                "POUNDS",
            };
        }

        public static Settings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Settings();
                    }
                    return instance;
                }
            }
        }

    }
}

