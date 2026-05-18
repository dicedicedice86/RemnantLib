using RemnantLib.code.items;
using RemnantLib.code.systems;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace RemnantLib
{
    public class RemnantLibModSystem : ModSystem
    {

        //Global Spell Builder that mod systems should be able to access in order to fire spells
        public static SpellBuilderSystem SpellBuilder;
        public override void Start(ICoreAPI api)
        {
            SpellBuilder = new SpellBuilderSystem(); //Instancing spell builder here on startup
            api.RegisterItemClass(Mod.Info.ModID + ".debugwand", typeof(DebugWand));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {

        }

        public override void StartClientSide(ICoreClientAPI api)
        {

        }

    }
}
