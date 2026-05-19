using RemnantLib.code.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common.Entities;

namespace RemnantLib.code.abstracts
{
    public class SpellRuntime
    {
        public List<ISpellBehaviour> Behaviors = new();

        public Entity Entity;

        public bool Destroyed = false;
    }
}
