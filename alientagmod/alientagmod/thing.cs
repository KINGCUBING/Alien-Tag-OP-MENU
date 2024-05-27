using Il2CppDG.Tweening.Plugins.Core;
using Il2CppPhoton.Pun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Il2CppPhoton.Realtime;
using Il2CppExitGames.Client.Photon;

namespace alientagmod
{
    internal class thing
    {
        internal class protect
        {
            
            private static void Prefix(EventData photonEvent)
            {
                if (PhotonNetwork.InRoom && photonEvent.Code == 202)
                {
                    spamgame.thingdo++;
                }
            }

           
            private static bool Prefix()
            {
                return spamgame.thingdo < 30;
            }
        }
    }
}

