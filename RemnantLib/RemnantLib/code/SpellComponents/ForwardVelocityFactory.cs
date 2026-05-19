using RemnantLib.code.abstracts;
using RemnantLib.code.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemnantLib.code.SpellComponents
{
    public class ForwardVelocityFactory
        : ISpellBehaviorFactory
    {
        public ISpellBehaviour Create(SpellBehaviorDefinition definition)
        {
            float speed =
                definition.Get<float>("speed", 10f);

            return new ForwardVelocityBehavior(
                speed
            );
        }
    }
}
