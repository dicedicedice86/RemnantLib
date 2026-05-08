using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace RemnantLib
{
    public class RemnantLibModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        // It's Me
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod plus testy: " + api.Side);
            Mod.Logger.Notification("It's Me" + api.Side);
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("remnantlib:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("remnantlib:hello"));
        }

    }
}
