using RemnantLib.code.abstracts;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

namespace RemnantLib.code.systems
{
    //This class is the spell builder that is accessed by the mod systems in order to instance the spells that they build into the game world.

    //ALL spell instancing logic should happen here, the individual behaviours of the spells can be altered and configured in a Spell class, or through a mod system. But the-
    //actual instancing should happen here. Do NOT rely on the mod systems to instance spells in any manner

    public class SpellBuilderSystem
    {

        //Temporary function (MAKE SURE ITS ACTUALLY TEMPORARY I AM PERSONALLY GIVING THIS VERY FUNCTION A LIFETIME OF 7 DAYS)
        public void BuildSpell(Spell spell, EntityPlayer firedBy)
        {
            (firedBy.Api as ICoreServerAPI)?.BroadcastMessageToAllGroups($"Player {firedBy.Player.PlayerName} fired Spell {spell}", EnumChatType.Notification);
            firedBy.Api.Logger.Notification($"Player {firedBy.Player.PlayerName} fired Spell {spell}", EnumChatType.Notification);
        }
    }
}
