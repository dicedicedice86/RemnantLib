using RemnantLib.code.abstracts;
using RemnantLib.code.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace RemnantLib.code
{
    public class SpellEntity : Entity
    {
        public SpellRuntime Runtime;

        public override void OnGameTick(float deltaTime)
        {
            base.OnGameTick(deltaTime);

            if (Runtime == null)
            {
                return;
            }

            foreach (ISpellBehaviour behavior
                in Runtime.Behaviors)
            {
                behavior.OnTick(Runtime, deltaTime);
            }

            if (Runtime.Destroyed)
            {
                Die();
            }
        }

        public void TriggerImpact(Entity target,BlockPos pos)
        {
            foreach (ISpellBehaviour behavior
                in Runtime.Behaviors)
            {
                behavior.OnImpact(
                    Runtime,
                    target,
                    pos
                );
            }
        }

        public override void Die(EnumDespawnReason reason = EnumDespawnReason.Death, DamageSource damageSourceForDeath = null)
        {
            if (Runtime != null)
            {
                foreach (ISpellBehaviour behavior
                    in Runtime.Behaviors)
                {
                    behavior.OnDestroy(Runtime);
                }
            }

            base.Die(reason, damageSourceForDeath);
        }
    }
}
