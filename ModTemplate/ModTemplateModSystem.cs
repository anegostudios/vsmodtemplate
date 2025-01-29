using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace ModTemplate
{
    public class ModTemplateModSystem : ModSystem
    {
        // Called on server and client
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + Lang.Get("mymodid:hello"));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from template mod server side");
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from template mod client side");
        }
    }
}
