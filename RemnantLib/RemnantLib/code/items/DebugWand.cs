using RemnantLib.code.abstracts;
using RemnantLib.code.systems;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common;

namespace RemnantLib.code.items
{
    //Debug wand class that we can use for now to test behaviours of spells and such
    internal class DebugWand : Item
    {
        public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, bool firstEvent, ref EnumHandHandling handling)
        {
            base.OnHeldInteractStart(slot, byEntity, blockSel, entitySel, firstEvent, ref handling);
            if (byEntity == null) return;
            EntityPlayer player = (EntityPlayer)byEntity;
            if (player == null) return;
        }
    }
}
