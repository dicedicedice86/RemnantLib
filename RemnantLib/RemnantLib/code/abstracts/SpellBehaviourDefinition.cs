using System;
using System.Collections.Generic;
using System.Text;

namespace RemnantLib.code.abstracts
{
    public class SpellBehaviorDefinition
    {
        public string Code;

        public Dictionary<string, object> Parameters = new();

        public T Get<T>(string key, T fallback = default)
        {
            if (Parameters.TryGetValue(key, out object value))
            {
                return (T)value;
            }

            return fallback;
        }
    }
}
