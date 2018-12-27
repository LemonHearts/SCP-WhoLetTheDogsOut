using Smod2;
using Smod2.Attributes;
using Smod2.Config;

namespace WhoLetTheDogsOut
{
    [PluginDetails(
        author = "Lemon Hearts",
        name = "Who Let The Dogs Out",
        description = "Standard SCP:SL, except Guards and Dogs everywhere!",
        id = "lemon.gamemode.wholetthedogsout",
        version = "1.0.1",
        SmodMajor = 3,
        SmodMinor = 2,
        SmodRevision = 0
        )]
    public class WhoLetTheDogsOut : Plugin
    {
        public override void OnDisable()
        {

        }

        public override void OnEnable()
        {
            Info("Bark Bark Bark - Enabled");
        }

        public override void Register()
        {
            AddEventHandlers(new EventHandler(this));
            GamemodeManager.GamemodeManager.RegisterMode(this, "01101101101101101101");
        }
    }
}
