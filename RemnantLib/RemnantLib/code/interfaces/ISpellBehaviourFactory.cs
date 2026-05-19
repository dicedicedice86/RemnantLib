using RemnantLib.code.abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RemnantLib.code.interfaces
{
    public interface ISpellBehaviorFactory
    {
        ISpellBehaviour Create(
            SpellBehaviorDefinition definition
        );
    }
}
