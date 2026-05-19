using RemnantLib.code.abstracts;
using RemnantLib.code.systems;
using System;
using System.Collections.Generic;
using System.Text;
using Vintagestory.API.Common;
using Vintagestory.API.Common.Entities;

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

            SpellDefinition spell = new SpellDefinition();

            SpellBehaviorDefinition velocity = new SpellBehaviorDefinition();

            velocity.Code = "forwardvelocity";
            velocity.Parameters["speed"] = 20f;

            spell.Behaviors.Add(velocity);

            SpellRuntime runtime = RemnantLibModSystem.SpellBuilder.Build(spell);

            AssetLocation spellAsset = AssetLocation.Create("spellentity", "remnantlib");
            EntityProperties type = api.World.GetEntityType(spellAsset);
            SpellEntity entity = api.World.ClassRegistry.CreateEntity(type) as SpellEntity;

            entity.Runtime = runtime;

            runtime.Entity = entity;

            entity.Pos.SetPos(player.Pos);
            player.World.SpawnEntity(entity);

        }
    }
}
