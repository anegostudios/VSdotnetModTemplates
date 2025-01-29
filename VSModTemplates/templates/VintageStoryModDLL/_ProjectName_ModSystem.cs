#if( AddSampleCode )
using Vintagestory.API.Client;
using Vintagestory.API.Server;
using Vintagestory.API.Config;
#endif
using Vintagestory.API.Common;

[assembly: ModInfo("_ProjectName_", "_ProjectName_",
                    Authors = new string[] { "Unknown" },
                    Description = "This is a sample mod",
                    Version = "1.0.0")]
namespace _ProjectName_
{
    public class _ProjectName_ModSystem : ModSystem
    {
#if( AddSampleCode )
        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + api.Side);
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            Mod.Logger.Notification("Hello from template mod server side: " + Lang.Get("_ProjectName_:hello"));
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
            Mod.Logger.Notification("Hello from template mod client side: " + Lang.Get("_ProjectName_:hello"));
        }
#endif
    }
}
