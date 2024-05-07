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
        public System.String room = "roomhere";
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

        
        string fakeusername = "endiskingfake" + randomNumber1.ToString() + randomNumber2.ToString();
        string fakeid = "endiskingfake" + randomNumber1.ToString() + randomNumber2.ToString();


        string fakephotonCustomAuthenticationToken = makearandostringg(16);
        Color startColor = Color.grey;
        Color endColor = Color.black;

       
        public float lerpDuration = 2f;

       
        private float lerpTimer = 0f;
       

        
    

        
    







        public override void OnUpdate()
        {


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
                
                PhotonNetwork.LocalPlayer.NickName = "<color=red><size=4>ENDISKINGRUNSYOU</color></size>";
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
            hardcrash = GUILayout.Toggle(hardcrash, "HardCrash");
            die = GUILayout.Toggle(die, "Spaceship Spam");
            durr = GUILayout.Toggle(durr, "NameAll");
            car = GUILayout.Toggle(car, "Fling/LagAll");

            boy = GUILayout.Toggle(boy, "DollSpam");
            if (GUILayout.Button("RemoveActorNumber"))
            {
                PhotonNetwork.CurrentRoom.players.Remove(PhotonNetwork.LocalPlayer.ActorNumber);

            }
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









