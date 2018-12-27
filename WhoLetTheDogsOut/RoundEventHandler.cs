using Smod2.EventHandlers;
using Smod2.EventSystem.Events;

namespace WhoLetTheDogsOut
{
    partial class EventHandler : IEventHandlerSetSCPConfig
    {
        public void OnSetSCPConfig(SetSCPConfigEvent ev)
        {
            if (GamemodeManager.GamemodeManager.GetCurrentMode().Equals(plugin))
            {
                ev.Ban049 = true;
                ev.Ban079 = true;
                ev.Ban096 = true;
                ev.Ban106 = true;
                ev.Ban173 = true;
                ev.Ban939_53 = false;
                ev.Ban939_89 = false;
                ev.SCP939_53amount = 4;
                ev.SCP939_89amount = 4;
            }
        }
        
        public void OnTeamRespawn(SetTeamRespawnEvent ev)
        {
            if(GamemodeManager.GamemodeManager.GetCurrentMode().Equals(plugin))
            {
                for(int i = 0; i < ev.playerList.Count;i++)
                {
                    ev.playerList.spawnMTF = true;
                }
            }
        }
    }
}
