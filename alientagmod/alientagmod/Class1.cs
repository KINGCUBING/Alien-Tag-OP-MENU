using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using Il2CppPhoton.Realtime;
using Il2CppPhoton.Pun;
using Il2Cpp;
using Il2CppPhoton.VR;
using System.Diagnostics.Eventing.Reader;
using Il2CppPlayFab.ClientModels;
using Il2CppPlayFab;

namespace alientagmod
{
    public class ReelMod : MelonMod
    {

        public bool thick;
        public bool hasdone;
        public bool die;
        public bool durr;
        public string spaceshipTag = "Spaceship(Clone)";
        public bool car;
        public bool boy;
        public bool toy;
        public bool fun;
        public bool thing;
        public static int thingdo;
       





        public override void OnUpdate()
        {

            if (!PhotonNetwork.IsMasterClient)
            {

                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
            }

            if (PhotonNetwork.IsConnected && !hasdone)
            {

                PhotonNetwork.LocalPlayer.NickName = "ENDISKINGRUNS YOU";
                hasdone = true;
            }

            if (thick)
            {

                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);

            }
            if (die)

            {
                PhotonNetwork.Instantiate("SpaceShip", Camera.main.transform.position, Camera.main.transform.rotation);
            }

            if (durr)
            {

                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                foreach (Player player in PhotonNetwork.PlayerListOthers)
                {
                    if (player.actorNumber != PhotonNetwork.LocalPlayer.actorNumber)

                    {
                        PhotonNetwork.TransferOwnership(player.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
                        PhotonNetwork.RequestOwnership(player.actorNumber, PhotonNetwork.LocalPlayer.actorNumber);
                        player.actorNumber = PhotonNetwork.LocalPlayer.actorNumber;
                        player.NickName = "<color=red>ENDISKING RUNS YOU</color>";
                    }
                }
            }


            if (car)
            {
                PhotonNetwork.Instantiate("BigAsteroid", Camera.main.transform.position, Camera.main.transform.rotation);





            }


            if (boy)

            {
                PhotonNetwork.Instantiate("Boy-Local", Camera.main.transform.position, Camera.main.transform.rotation);
               

            }
            if (thing)
            {
                PhotonNetwork.Instantiate("Hellephant", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("SpaceShip", Camera.main.transform.position, Camera.main.transform.rotation);

            }

        }


    
        





        public override void OnInitializeMelon()
        {
            MelonEvents.OnGUI.Subscribe(DrawMenu, 100);
        }

        private void DrawMenu()
        {
            GUILayout.Box("ENDISKINGS OP MENU");
            if (GUILayout.Button("Leave"))
            {
                PhotonNetwork.Disconnect();

            }
            thick = GUILayout.Toggle(thick, "RigSpam");
            thing = GUILayout.Toggle(thing, "NUKE");

            if (GUILayout.Button("SetMaster"))
            {
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);

            }
            die = GUILayout.Toggle(die, "Spaceship Spam");
            durr = GUILayout.Toggle(durr, "NameAll");
            car = GUILayout.Toggle(car, "Fling/LagAll");

            boy = GUILayout.Toggle(boy, "DollSpam");
            if (GUILayout.Button("255 Players"))
            {
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                PhotonNetwork.CurrentRoom.maxPlayers = byte.MaxValue;

            }
            if (GUILayout.Button("DistroyAllPlayers"))
            {
                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                foreach (Player player in PhotonNetwork.PlayerListOthers)
                {
                    PhotonNetwork.DestroyPlayerObjects(player);

                }
            }

            if (GUILayout.Button("LockRoom"))
            {
                PhotonNetwork.CurrentRoom.isOpen = false;
                PhotonNetwork.CurrentRoom.isVisible = false;

            }


            if (GUILayout.Button("DistroyPrefabs"))
            {
                PhotonNetwork.DestroyAll();

            }
            if (GUILayout.Button("CloseRoom(NW)"))
            {
                //thick5();

            }

            if (GUILayout.Button("UnLock/UnPrivRoom"))
            {
                PhotonNetwork.CurrentRoom.isOpen = true;
                PhotonNetwork.CurrentRoom.isVisible = true;
            }





        }


    }
}









