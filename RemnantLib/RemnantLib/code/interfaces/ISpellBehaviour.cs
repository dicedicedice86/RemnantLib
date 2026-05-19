using RemnantLib.code.abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common.Entities;
using Vintagestory.API.MathTools;

namespace RemnantLib.code.interfaces
{
    public interface ISpellBehaviour
    {
        void OnSpawn(SpellRuntime spell);

        void OnTick(SpellRuntime spell, float deltaTime);

        void OnImpact(
            SpellRuntime spell,
            Entity target,
            BlockPos pos
        );

        void OnDestroy(SpellRuntime spell);
    }
}
