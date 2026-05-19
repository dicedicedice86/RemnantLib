using RemnantLib.code.abstracts;
using RemnantLib.code.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace RemnantLib.code.SpellComponents
{
    public class ForwardVelocityBehavior
        : ISpellBehaviour
    {
        private float speed;

        public ForwardVelocityBehavior(float speed)
        {
            this.speed = speed;
        }

        public void OnSpawn(SpellRuntime spell)
        {

        }

        public void OnDestroy(SpellRuntime spell)
        {

        }

        public void OnImpact(SpellRuntime spell, Entity target, BlockPos pos)
        {
            
        }

        public void OnTick(SpellRuntime spell, float deltaTime)
        {
            // Do some velocity shite here, since this is basically an Update function for the spell
            Entity spellent = spell.Entity; // Use this to get the runtime entity that the spell is controlling
        }
    }
}
