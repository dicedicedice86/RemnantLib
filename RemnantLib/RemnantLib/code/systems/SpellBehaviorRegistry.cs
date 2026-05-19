using RemnantLib.code.abstracts;
using RemnantLib.code.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemnantLib.code.systems
{
    //Registry that stores all the different spell behaviours, obviously this cant exactly be changed at runtime but that should be fine
    public static class SpellBehaviorRegistry
    {
        private static Dictionary<string,
            ISpellBehaviorFactory> registry = new();

        public static void Register(string code,ISpellBehaviorFactory factory)
        {
            registry[code] = factory;
        }

        public static ISpellBehaviour Create(SpellBehaviorDefinition definition)
        {
            return registry[definition.Code]
                .Create(definition);
        }
    }
}
