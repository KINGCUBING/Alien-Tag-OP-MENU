using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;
using Il2CppPhoton.Realtime;
using Il2CppPhoton.Pun;

using Il2CppPhoton.VR;
using System.Diagnostics.Eventing.Reader;
using Il2CppPlayFab.ClientModels;
using Il2CppPlayFab;
using System.Linq.Expressions;
using Random = System.Random;
using UnityEngine.XR.Interaction.Toolkit;
using Il2Cpp;
using Il2CppPhoton.Pun.Demo.PunBasics;
using System.Reflection;
using static Il2Cpp.re;
using Il2CppPhoton.VR.Player;

namespace alientagmod
{
    public class spamgame : MelonMod
    {
        private bool showPlayerList = false;
        private Rect windowRect = new Rect(100, 100, 200, 300);
        private Il2CppPhoton.Realtime.Player[] players;

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
        public bool jokersrpc;
        public static int thingdo;
        public Il2CppSystem.String room = "roomhere";
        public string account;
        public string id;
        public string endiskingfake;
        public string fake = "a270a357-7063-42bb-b24d-cf45038adc1e";
        public string voce = "e87a3e5e-14a6-4f54-bcb7-ed8228ccfb0a";
        public string titleid = "A17FB";
        static Random random = new Random();
        public static int randomNumber1 = random.Next(1000);
        public static int randomNumber2 = random.Next(1000);
        public bool hardcrash;
        public bool gamemodespam;
        public string stringthing = "<color=red>ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU ENDISKINGRUNSYOU</color>";
        public string namechange = "<color=red>ENDISKING RUNS YOU #DOWNWITHALIENTAG</color>";

        string fakeusername = "endiskingfake" + randomNumber1.ToString() + randomNumber2.ToString();
        string fakeid = "endiskingfake" + randomNumber1.ToString() + randomNumber2.ToString();


        string fakephotonCustomAuthenticationToken = makearandostringg(16);
        Color startColor = Color.grey;
        Color endColor = Color.black;


        public float lerpDuration = 2f;


        private float lerpTimer = 0f;














        public override void OnUpdate()
        {


            foreach (var player in PhotonNetwork.PlayerList)
            {

                if (player.NickName.Contains("JOKERMODZ"))
                {

                    GameObject playerObject = GameObject.Find(player.NickName);
                    if (playerObject != null)
                    {
                        PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                        PhotonNetwork.Destroy(playerObject);
                    }
                }
            }
            if (PhotonNetwork.InRoom)
            {
                PhotonVRManager.Manager.LocalPlayer.RefreshPlayerValues();

            }

            this.lerpTimer += Time.deltaTime;
            if (this.lerpTimer > this.lerpDuration)
            {
                this.lerpTimer = 0f;
            }

            float num = this.lerpTimer / this.lerpDuration;


            Color startColor = Color.grey;
            Color endColor = Color.black;


            Color colour = Color.Lerp(startColor, endColor, num);
            PhotonVRManager.SetColour(colour);

            if (!PhotonNetwork.IsMasterClient)
            {

                PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);

                PhotonNetwork.LocalPlayer.NickName = "<size=4><sprite name=\"wawa\"></size><color=red><size=4>ENDISKING_RUNS_YOU</size></color><size=4><sprite name=\"wawa\"></size>";
                PlayerPrefs.SetString("PhotonUsername", "ENDISKINGRUNSYOU");
            }

            if (PhotonNetwork.IsConnected && !hasdone)
            {

                PhotonNetwork.LocalPlayer.NickName = "ENDISKINGRUNS YOU";
                hasdone = true;
            }

            if (thick)
            {
                PhotonNetwork.CurrentRoom.Players.Remove(PhotonNetwork.LocalPlayer.ActorNumber);

                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);

            }
            if (gamemodespam)
            {
                Spamgame();

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

                    player.NickName = namechange;
                    Type typeFromHandle = typeof(Player);
                    MethodInfo method = typeFromHandle.GetMethod("SetPlayerNameProperty", BindingFlags.Instance | BindingFlags.NonPublic);
                    if (method != null)
                    {
                        method.Invoke(player, new object[0]);
                    }
                }
            }


            if (car)
            {
                PhotonNetwork.Instantiate("BigAsteroid", Camera.main.transform.position, Camera.main.transform.rotation);





            }

            if (jokersrpc)
            {

                string[] Text = new string[]
                    {

                      "<color=red>ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU</color>", "<color=green>ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU</color>", "<color=grey>ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU</color>", "<color=red>ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU ENDISKING ON TOP ENDISKING ON TOP ENDISKING ON TOP ENDISKING OWNS YOU</color>"
                    };

                int thing = new System.Random().Next(Text.Length);

                PhotonView view = GameObject.Find("GameManager").GetComponent<PhotonView>();
                view.TransferOwnership(PhotonNetwork.LocalPlayer);
                view.RPC("UpdateNoticeText", RpcTarget.AllBuffered, Text[thing]);


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

            if (hardcrash)
            {
                PhotonNetwork.CurrentRoom.Players.Remove(PhotonNetwork.LocalPlayer.ActorNumber);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);
                PhotonNetwork.Instantiate("PhotonVR/Characters/PlayerAlien", Camera.main.transform.position, Camera.main.transform.rotation);

            }

        }

        public void authspoof()
        {
            PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime = "a270a357-7063-42bb-b24d-cf45038adc1e";
            PhotonNetwork.photonServerSettings.AppSettings.AppIdVoice = "e87a3e5e-14a6-4f54-bcb7-ed8228ccfb0a";
            PlayFabSettings.TitleId = "A17FB";

            login();

        }


        public void login()
        {

            PlayFabClientAPI.LoginWithCustomID(new LoginWithCustomIDRequest
            {

                CustomId = fakeid,
                //CreateAccount = (Il2CppSystem.boolen<bool>)true
                InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
                {
                    GetPlayerProfile = true
                }
            }, new System.Action<LoginResult>(this.OnLoginSuccess), new System.Action<PlayFabError>(this.OnError), null, null);


        }


        public void OnLoginSuccess(LoginResult result)
        {
            Debug.Log("trying to get the token...");
            PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest(), new System.Action<GetAccountInfoResult>(this.AccountInfoSuccess), new System.Action<PlayFabError>(this.OnError), null, null);
            string @string = PlayerPrefs.GetString("PhotonUsername");
            PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest
            {
                DisplayName = @string
            }, new System.Action<UpdateUserTitleDisplayNameResult>(this.UpdatedName), new System.Action<PlayFabError>(this.ErrorUpdatingName), null, null);
        }


        private void UpdatedName(UpdateUserTitleDisplayNameResult result)
        {
            Debug.Log("did thing");
        }


        private void ErrorUpdatingName(PlayFabError error)
        {
            Debug.Log("couldent do it but its prob fine");
        }

        // Token: 0x060000EB RID: 235 RVA: 0x0000B4B4 File Offset: 0x000096B4
        public void AccountInfoSuccess(GetAccountInfoResult result)
        {

            PlayerPrefs.GetString("PhotonUsername");
            this.RequestPhotonToken();
            /*PlayFabClientAPI.GetUserInventory(new GetUserInventoryRequest(), delegate (GetUserInventoryResult result)
            {
                foreach (ItemInstance itemInstance in result.Inventory)
                {
                    if (itemInstance.CatalogVersion == this.CatalogName)
                    {
                        for (int i = 0; i < this.specialitems.Count; i++)
                        {
                            if (this.specialitems[i].name == itemInstance.ItemId)
                            {
                                this.specialitems[i].SetActive(true);
                            }
                        }
                    }
                }
            }, delegate (PlayFabError error)
            {
                Debug.LogError(error.GenerateErrorReport());
            }, null, null);
        }*/
        }


        private void OnError(PlayFabError error)
        {
        }


        public void RequestPhotonToken()
        {
            PlayFabClientAPI.GetPhotonAuthenticationToken(new GetPhotonAuthenticationTokenRequest
            {
                PhotonApplicationId = (PhotonNetwork.PhotonServerSettings.AppSettings.AppIdRealtime = fake)
            }, new System.Action<GetPhotonAuthenticationTokenResult>(this.OnPhotonTokenSuccess), new System.Action<PlayFabError>(this.OnPhotonTokenError), null, null);
        }


        private void OnPhotonTokenSuccess(GetPhotonAuthenticationTokenResult result)
        {
            string photonCustomAuthenticationToken = result.PhotonCustomAuthenticationToken;
            PhotonNetwork.AuthValues = new AuthenticationValues();
            PhotonNetwork.AuthValues.AuthType = CustomAuthenticationType.Custom;
            PhotonNetwork.AuthValues.AddAuthParameter("username", fakeusername);
            PhotonNetwork.AuthValues.AddAuthParameter("token", fakephotonCustomAuthenticationToken);
            Debug.Log("Authenticating");
            Debug.Log("theymessedupnow");
            PhotonNetwork.ConnectUsingSettings();
        }


        private void OnPhotonTokenError(PlayFabError error)
        {
            Debug.Log("itfailed: " + error.GenerateErrorReport());

        }

        static string makearandostringg(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void Spamgame()
        {
           
            {
               
               /// cq.

            }


        }
    










        public override void OnInitializeMelon()
        {
            MelonEvents.OnGUI.Subscribe(DrawMenu, 100);
        }

        private void DrawMenu()
        {
            GUILayout.Box("ENDISKINGS OP MENU");
            if (GUILayout.Button("FakeAuth"))
            {
                PhotonNetwork.NickName = "ENDISKIMGRUNSYOU";
                PlayerPrefs.SetString("PhotonUsername", "ENDISKINGRUNSYOU");
                authspoof();

            }
            //room = GUI.TextField(new Rect(0, 20, 100, 20), room);

            if (GUILayout.Button("JoinRoom"))
            {
                PhotonNetwork.JoinRoom(room);

            }




            if (showPlayerList)
            {
                windowRect = GUILayout.Window(0, windowRect, (GUI.WindowFunction)dowindwothing, "Player STUFF");
            }

            if (GUILayout.Button("Leave"))
            {
                PhotonNetwork.Disconnect();
            }

                showPlayerList = GUILayout.Toggle(showPlayerList, "Player Window");
                thick = GUILayout.Toggle(thick, "RigSpam");
                thing = GUILayout.Toggle(thing, "NUKE");

                if (GUILayout.Button("SetMaster"))
                {
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);

                }
            
            jokersrpc = GUILayout.Toggle(jokersrpc, "Update Game Text SS C:J0kerModz");
            gamemodespam = GUILayout.Toggle(gamemodespam, "Game Mode Spam NW");
            hardcrash = GUILayout.Toggle(hardcrash, "HardCrash");
                die = GUILayout.Toggle(die, "Spaceship Spam");
                durr = GUILayout.Toggle(durr, "NameAll");
                car = GUILayout.Toggle(car, "Fling/LagAll");
           

            boy = GUILayout.Toggle(boy, "DollSpam");
                if (GUILayout.Button("RemoveActorNumber"))
                {
                    PhotonNetwork.CurrentRoom.players.Remove(PhotonNetwork.LocalPlayer.ActorNumber);

                }
                // didnt work im so dumb
           // if (GUILayout.Button("Update Game Text SS"))
            {
                //GameObject gameManagerObj = GameObject.Find("GameManager");

               
               // if (gameManagerObj != null)
                {
                   
                   // GameManager gameManager = gameManagerObj.GetComponent<GameManager>();

                  
                   // if (gameManager != null)
                    {
                       
                       // for (int i = 0; i < 15; i++)
                        {
                           // gameManager.photonView.TransferOwnership(PhotonNetwork.LocalPlayer);
                        }


                       // gameManager.photonView.RPC("UpdateNoticeText", RpcTarget.AllBuffered, stringthing);


                    }
                }
            }
            if (GUILayout.Button("Set GameMode Infection"))
            {
                PhotonVRManager._Manager_k__BackingField.UpdateGameModeRPC(1);

            }
            if (GUILayout.Button("Reset GameMode"))
            {
                PhotonVRManager._Manager_k__BackingField.UpdateGameModeRPC(0);

            }
            if (GUILayout.Button("255 Players"))
                {
                    PhotonNetwork.SetMasterClient(PhotonNetwork.LocalPlayer);
                    PhotonNetwork.CurrentRoom.maxPlayers = int.MaxValue;

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



            void dowindwothing(int windowID)
            {
                GUILayout.BeginVertical();


                players = PhotonNetwork.PlayerListOthers;
            foreach (Il2CppPhoton.Realtime.Player player in players)
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label("Player Actor: " + player.ActorNumber);


                GUILayout.Label("UserName: " + player.NickName);


                if (GUILayout.Button("Invis Child " + player.NickName))
                {
                    DestroyChilds(player);
                }

                GUILayout.EndHorizontal();
               
              
            }
                GUILayout.EndVertical();

            GUI.DragWindow(new Rect(0, 0, 10000, 20));

            void DestroyChilds(Il2CppPhoton.Realtime.Player player)
                {
                    PhotonNetwork.DestroyPlayerObjects(player);
                }

            void GETChilds(Il2CppPhoton.Realtime.Player player)
            {
                PhotonNetwork.DestroyPlayerObjects(player);
            }

            
                }
            }
        }
    






  


    










